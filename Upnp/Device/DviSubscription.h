#ifndef HEADER_DVISUBSCRIPTION
#define HEADER_DVISUBSCRIPTION

#include <OhNetTypes.h>
#include <Buffer.h>
#include <Network.h>
#include <Service.h>
#include <Timer.h>
#include <Thread.h>
#include <Fifo.h>

#include <vector>
#include <map>
#include <list>

namespace OpenHome {
namespace Net {

class IDviSubscriptionUserData
{
public:
    virtual const void* Data() const = 0;
    virtual void Release() = 0;
};
    
class IPropertyWriterFactory
{
public:
    virtual IPropertyWriter* CreateWriter(const IDviSubscriptionUserData* aUserData, 
                                          const Brx& aSid, TUint aSequenceNumber) = 0;
};

class DviDevice;
class DviService;
class DviSubscription
{
public:
    DviSubscription(DviDevice& aDevice, IPropertyWriterFactory& aWriterFactory,
                    IDviSubscriptionUserData* aUserData, Brh& aSid, TUint& aDurationSecs);
    void Start(DviService& aService);
    void Stop();
    void AddRef();
    void RemoveRef();
    void Renew(TUint& aSeconds);
    void WriteChanges();
    const Brx& Sid() const;
    TBool PropertiesInitialised() const;
    TBool HasExpired() const;
private:
    ~DviSubscription();
    IPropertyWriter* CreateWriter();
    void Expired();
private:
    mutable Mutex iLock;
    TUint iRefCount;
    DviDevice& iDevice;
    IPropertyWriterFactory& iWriterFactory;
    IDviSubscriptionUserData* iUserData;
    Brh iSid;
    DviService* iService;
    std::vector<TUint> iPropertySequenceNumbers;
    TUint iSequenceNumber;
    Timer* iTimer;
    TBool iExpired;
};

class PropertyWriter : public IPropertyWriter
{
protected:
    PropertyWriter();
    void SetWriter(IWriter& aWriter);
private: // IPropertyWriter
    void PropertyWriteString(const Brx& aName, const Brx& aValue);
    void PropertyWriteInt(const Brx& aName, TInt aValue);
    void PropertyWriteUint(const Brx& aName, TUint aValue);
    void PropertyWriteBool(const Brx& aName, TBool aValue);
    void PropertyWriteBinary(const Brx& aName, const Brx& aValue);
private:
    void WriteVariable(const Brx& aName, const Brx& aValue);
private:
    IWriter* iWriter;
};

class Publisher : public Thread
{
public:
    Publisher(const TChar* aName, Fifo<Publisher*>& aFree);
    ~Publisher();
    void Publish(DviSubscription* aSubscription);
private:
    void Error(const TChar* aErr);
    void Run();
private:
    Fifo<Publisher*>& iFree;
    DviSubscription* iSubscription;
};

class DviSubscriptionManager : public Thread
{
public:
    DviSubscriptionManager();
    ~DviSubscriptionManager();
    static void AddSubscription(DviSubscription& aSubscription);
    static void RemoveSubscription(DviSubscription& aSubscription);
    static DviSubscription* Find(const Brx& aSid);
    static void QueueUpdate(DviSubscription& aSubscription);
private:
    static DviSubscriptionManager& Self();
    void Run();
private:
    Mutex iLock;
    std::list<DviSubscription*> iList;
    Fifo<Publisher*> iFree;
    Publisher** iPublishers;
    typedef std::map<Brn,DviSubscription*,BufferCmp> Map;
    Map iMap;
};

} // namespace Net
} // namespace OpenHome

#endif // HEADER_DVISUBSCRIPTION
