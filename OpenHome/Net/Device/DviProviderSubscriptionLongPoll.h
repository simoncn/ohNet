#ifndef HEADER_DVI_PROVIDER_SUBSCRIPTION_LONGPOLL
#define HEADER_DVI_PROVIDER_SUBSCRIPTION_LONGPOLL

#include <OpenHome/OhNetTypes.h>
#include <OpenHome/Buffer.h>
#include <OpenHome/Net/Core/DvOpenhomeOrgSubscriptionLongPoll1.h>
#include <OpenHome/Net/Core/DvDevice.h>
#include <OpenHome/Private/Thread.h>

#include <vector>
#include <map>
#include <list>

namespace OpenHome {
namespace Net {

class DviPropertyUpdateCollection;
    
class DviProviderSubscriptionLongPoll : public DvProviderOpenhomeOrgSubscriptionLongPoll1
{
public:
    DviProviderSubscriptionLongPoll(DvDevice& aDevice);
    ~DviProviderSubscriptionLongPoll();
private: // DvProviderOpenhomeOrgSubscriptionLongPoll1
    void Subscribe(IDvInvocation& aInvocation, const Brx& aClientId, const Brx& aUdn, const Brx& aService, TUint aRequestedDuration, IDvInvocationResponseString& aSid, IDvInvocationResponseUint& aDuration);
    void Unsubscribe(IDvInvocation& aInvocation, const Brx& aSid);
    void Renew(IDvInvocation& aInvocation, const Brx& aSid, TUint aRequestedDuration, IDvInvocationResponseUint& aDuration);
    void GetPropertyUpdates(IDvInvocation& aInvocation, const Brx& aClientId, IDvInvocationResponseString& aUpdates);
private:
    static const TUint kTimeoutLongPollSecs = 5 * 60; // 5 mins
    static const TUint kGetUpdatesMaxDelay = 30 * 1000; // 30 secs
private:
    DviPropertyUpdateCollection& iPropertyUpdateCollection;
    Semaphore iUpdatesReady;
    Semaphore iShutdown;
    TBool iExit;
    TUint iClientCount;
};

} // namespace Net
} // namespace OpenHome

#endif // HEADER_DVI_PROVIDER_SUBSCRIPTION_LONGPOLL