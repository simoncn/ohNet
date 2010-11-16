#ifndef HEADER_DVLINNCOUKDS1
#define HEADER_DVLINNCOUKDS1

#include <ZappTypes.h>
#include <Buffer.h>
#include <Core/DvDevice.h>
#include <DvProvider.h>

namespace Zapp {

class IDviInvocation;
class PropertyInt;
class PropertyUint;
class PropertyBool;
class PropertyString;
class PropertyBinary;

/**
 * Base Device for linn.co.uk:Ds:1
 */
class DvProviderLinnCoUkDs1 : public DvProvider
{
public:
    virtual ~DvProviderLinnCoUkDs1() {}
    TBool SetPropertySupportedProtocols(const Brx& aValue);
    void GetPropertySupportedProtocols(Brhz& aValue);
    TBool SetPropertyTrackDuration(TUint aValue);
    void GetPropertyTrackDuration(TUint& aValue);
    TBool SetPropertyTrackBitRate(TUint aValue);
    void GetPropertyTrackBitRate(TUint& aValue);
    TBool SetPropertyTrackLossless(TBool aValue);
    void GetPropertyTrackLossless(TBool& aValue);
    TBool SetPropertyTrackBitDepth(TUint aValue);
    void GetPropertyTrackBitDepth(TUint& aValue);
    TBool SetPropertyTrackSampleRate(TUint aValue);
    void GetPropertyTrackSampleRate(TUint& aValue);
    TBool SetPropertyTrackCodecName(const Brx& aValue);
    void GetPropertyTrackCodecName(Brhz& aValue);
    TBool SetPropertyTrackId(TUint aValue);
    void GetPropertyTrackId(TUint& aValue);
    TBool SetPropertyTransportState(const Brx& aValue);
    void GetPropertyTransportState(Brhz& aValue);
protected:
    DvProviderLinnCoUkDs1(DvDevice& aDevice);
    void EnableActionPlay();
    void EnableActionPause();
    void EnableActionStop();
    void EnableActionSeekSecondAbsolute();
    void EnableActionSeekSecondRelative();
    void EnableActionSeekTrackId();
    void EnableActionSeekTrackAbsolute();
    void EnableActionSeekTrackRelative();
    void EnableActionState();
    void EnableActionProtocolInfo();
private:
    virtual void Play(IInvocationResponse& aResponse, TUint aVersion);
    virtual void Pause(IInvocationResponse& aResponse, TUint aVersion);
    virtual void Stop(IInvocationResponse& aResponse, TUint aVersion);
    virtual void SeekSecondAbsolute(IInvocationResponse& aResponse, TUint aVersion, TUint aaSecond);
    virtual void SeekSecondRelative(IInvocationResponse& aResponse, TUint aVersion, TInt aaSecond);
    virtual void SeekTrackId(IInvocationResponse& aResponse, TUint aVersion, TUint aaTrackId);
    virtual void SeekTrackAbsolute(IInvocationResponse& aResponse, TUint aVersion, TUint aaTrack);
    virtual void SeekTrackRelative(IInvocationResponse& aResponse, TUint aVersion, TInt aaTrack);
    virtual void State(IInvocationResponse& aResponse, TUint aVersion, IInvocationResponseString& aaTransportState, IInvocationResponseUint& aaTrackDuration, IInvocationResponseUint& aaTrackBitRate, IInvocationResponseBool& aaTrackLossless, IInvocationResponseUint& aaTrackBitDepth, IInvocationResponseUint& aaTrackSampleRate, IInvocationResponseString& aaTrackCodecName, IInvocationResponseUint& aaTrackId);
    virtual void ProtocolInfo(IInvocationResponse& aResponse, TUint aVersion, IInvocationResponseString& aaSupportedProtocols);
private:
    DvProviderLinnCoUkDs1();
    void DoPlay(IDviInvocation& aInvocation, TUint aVersion);
    void DoPause(IDviInvocation& aInvocation, TUint aVersion);
    void DoStop(IDviInvocation& aInvocation, TUint aVersion);
    void DoSeekSecondAbsolute(IDviInvocation& aInvocation, TUint aVersion);
    void DoSeekSecondRelative(IDviInvocation& aInvocation, TUint aVersion);
    void DoSeekTrackId(IDviInvocation& aInvocation, TUint aVersion);
    void DoSeekTrackAbsolute(IDviInvocation& aInvocation, TUint aVersion);
    void DoSeekTrackRelative(IDviInvocation& aInvocation, TUint aVersion);
    void DoState(IDviInvocation& aInvocation, TUint aVersion);
    void DoProtocolInfo(IDviInvocation& aInvocation, TUint aVersion);
private:
    PropertyString* iPropertySupportedProtocols;
    PropertyUint* iPropertyTrackDuration;
    PropertyUint* iPropertyTrackBitRate;
    PropertyBool* iPropertyTrackLossless;
    PropertyUint* iPropertyTrackBitDepth;
    PropertyUint* iPropertyTrackSampleRate;
    PropertyString* iPropertyTrackCodecName;
    PropertyUint* iPropertyTrackId;
    PropertyString* iPropertyTransportState;
};

} // namespace Zapp

#endif // HEADER_DVLINNCOUKDS1

