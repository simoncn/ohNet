#include <Std/DvLinnCoUkProduct2.h>
#include <ZappTypes.h>
#include <DviService.h>
#include <Service.h>
#include <FunctorDviInvocation.h>

using namespace Zapp;

bool DvProviderLinnCoUkProduct2Cpp::SetPropertyProductName(const std::string& aValue)
{
    Brn buf((const TByte*)aValue.c_str(), (TUint)aValue.length());
    return SetPropertyString(*iPropertyProductName, buf);
}

void DvProviderLinnCoUkProduct2Cpp::GetPropertyProductName(std::string& aValue)
{
    const Brx& val = iPropertyProductName->Value();
    aValue.assign((const char*)val.Ptr(), val.Bytes());
}

bool DvProviderLinnCoUkProduct2Cpp::SetPropertyProductRoom(const std::string& aValue)
{
    Brn buf((const TByte*)aValue.c_str(), (TUint)aValue.length());
    return SetPropertyString(*iPropertyProductRoom, buf);
}

void DvProviderLinnCoUkProduct2Cpp::GetPropertyProductRoom(std::string& aValue)
{
    const Brx& val = iPropertyProductRoom->Value();
    aValue.assign((const char*)val.Ptr(), val.Bytes());
}

bool DvProviderLinnCoUkProduct2Cpp::SetPropertyProductStandby(bool aValue)
{
    return SetPropertyBool(*iPropertyProductStandby, aValue);
}

void DvProviderLinnCoUkProduct2Cpp::GetPropertyProductStandby(bool& aValue)
{
    aValue = iPropertyProductStandby->Value();
}

bool DvProviderLinnCoUkProduct2Cpp::SetPropertyProductSourceIndex(uint32_t aValue)
{
    return SetPropertyUint(*iPropertyProductSourceIndex, aValue);
}

void DvProviderLinnCoUkProduct2Cpp::GetPropertyProductSourceIndex(uint32_t& aValue)
{
    aValue = iPropertyProductSourceIndex->Value();
}

DvProviderLinnCoUkProduct2Cpp::DvProviderLinnCoUkProduct2Cpp(DvDeviceStd& aDevice)
    : DvProvider(aDevice.Device(), "linn.co.uk", "Product", 2)
{
    Functor empty;
    iPropertyProductName = new PropertyString(new ParameterString("ProductName"), empty);
    iService->AddProperty(iPropertyProductName); // passes ownership
    iPropertyProductRoom = new PropertyString(new ParameterString("ProductRoom"), empty);
    iService->AddProperty(iPropertyProductRoom); // passes ownership
    iPropertyProductStandby = new PropertyBool(new ParameterBool("ProductStandby"), empty);
    iService->AddProperty(iPropertyProductStandby); // passes ownership
    iPropertyProductSourceIndex = new PropertyUint(new ParameterUint("ProductSourceIndex"), empty);
    iService->AddProperty(iPropertyProductSourceIndex); // passes ownership
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionType()
{
    Zapp::Action* action = new Zapp::Action("Type");
    action->AddOutputParameter(new ParameterString("aType"));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoType);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionModel()
{
    Zapp::Action* action = new Zapp::Action("Model");
    action->AddOutputParameter(new ParameterString("aModel"));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoModel);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionName()
{
    Zapp::Action* action = new Zapp::Action("Name");
    action->AddOutputParameter(new ParameterRelated("aName", *iPropertyProductName));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoName);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionSetName()
{
    Zapp::Action* action = new Zapp::Action("SetName");
    action->AddInputParameter(new ParameterRelated("aName", *iPropertyProductName));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoSetName);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionRoom()
{
    Zapp::Action* action = new Zapp::Action("Room");
    action->AddOutputParameter(new ParameterRelated("aRoom", *iPropertyProductRoom));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoRoom);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionSetRoom()
{
    Zapp::Action* action = new Zapp::Action("SetRoom");
    action->AddInputParameter(new ParameterRelated("aRoom", *iPropertyProductRoom));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoSetRoom);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionStandby()
{
    Zapp::Action* action = new Zapp::Action("Standby");
    action->AddOutputParameter(new ParameterRelated("aStandby", *iPropertyProductStandby));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoStandby);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionSetStandby()
{
    Zapp::Action* action = new Zapp::Action("SetStandby");
    action->AddInputParameter(new ParameterRelated("aStandby", *iPropertyProductStandby));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoSetStandby);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionSourceCount()
{
    Zapp::Action* action = new Zapp::Action("SourceCount");
    action->AddOutputParameter(new ParameterRelated("aSourceCount", *iPropertyProductSourceIndex));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoSourceCount);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionSourceIndex()
{
    Zapp::Action* action = new Zapp::Action("SourceIndex");
    action->AddOutputParameter(new ParameterRelated("aSourceIndex", *iPropertyProductSourceIndex));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoSourceIndex);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionSetSourceIndex()
{
    Zapp::Action* action = new Zapp::Action("SetSourceIndex");
    action->AddInputParameter(new ParameterRelated("aSourceIndex", *iPropertyProductSourceIndex));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoSetSourceIndex);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::EnableActionSourceType()
{
    Zapp::Action* action = new Zapp::Action("SourceType");
    action->AddInputParameter(new ParameterRelated("aSourceIndex", *iPropertyProductSourceIndex));
    action->AddOutputParameter(new ParameterString("aSourceType"));
    FunctorDviInvocation functor = MakeFunctorDviInvocation(*this, &DvProviderLinnCoUkProduct2Cpp::DoSourceType);
    iService->AddAction(action, functor);
}

void DvProviderLinnCoUkProduct2Cpp::DoType(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    aInvocation.InvocationReadEnd();
    std::string respaType;
    Type(aVersion, respaType);
	aInvocation.InvocationWriteStart();
    InvocationResponseString respWriteraType(aInvocation, "aType");
    Brn buf_aType((const TByte*)respaType.c_str(), (TUint)respaType.length());
    respWriteraType.Write(buf_aType);
    aInvocation.InvocationWriteStringEnd("aType");
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoModel(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    aInvocation.InvocationReadEnd();
    std::string respaModel;
    Model(aVersion, respaModel);
	aInvocation.InvocationWriteStart();
    InvocationResponseString respWriteraModel(aInvocation, "aModel");
    Brn buf_aModel((const TByte*)respaModel.c_str(), (TUint)respaModel.length());
    respWriteraModel.Write(buf_aModel);
    aInvocation.InvocationWriteStringEnd("aModel");
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoName(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    aInvocation.InvocationReadEnd();
    std::string respaName;
    Name(aVersion, respaName);
	aInvocation.InvocationWriteStart();
    InvocationResponseString respWriteraName(aInvocation, "aName");
    Brn buf_aName((const TByte*)respaName.c_str(), (TUint)respaName.length());
    respWriteraName.Write(buf_aName);
    aInvocation.InvocationWriteStringEnd("aName");
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoSetName(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    Brhz buf_aName;
    aInvocation.InvocationReadString("aName", buf_aName);
    std::string aName((const char*)buf_aName.Ptr(), buf_aName.Bytes());
    aInvocation.InvocationReadEnd();
    SetName(aVersion, aName);
	aInvocation.InvocationWriteStart();
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoRoom(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    aInvocation.InvocationReadEnd();
    std::string respaRoom;
    Room(aVersion, respaRoom);
	aInvocation.InvocationWriteStart();
    InvocationResponseString respWriteraRoom(aInvocation, "aRoom");
    Brn buf_aRoom((const TByte*)respaRoom.c_str(), (TUint)respaRoom.length());
    respWriteraRoom.Write(buf_aRoom);
    aInvocation.InvocationWriteStringEnd("aRoom");
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoSetRoom(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    Brhz buf_aRoom;
    aInvocation.InvocationReadString("aRoom", buf_aRoom);
    std::string aRoom((const char*)buf_aRoom.Ptr(), buf_aRoom.Bytes());
    aInvocation.InvocationReadEnd();
    SetRoom(aVersion, aRoom);
	aInvocation.InvocationWriteStart();
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoStandby(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    aInvocation.InvocationReadEnd();
    bool respaStandby;
    Standby(aVersion, respaStandby);
	aInvocation.InvocationWriteStart();
    InvocationResponseBool respWriteraStandby(aInvocation, "aStandby");
    respWriteraStandby.Write(respaStandby);
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoSetStandby(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    bool aStandby = aInvocation.InvocationReadBool("aStandby");
    aInvocation.InvocationReadEnd();
    SetStandby(aVersion, aStandby);
	aInvocation.InvocationWriteStart();
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoSourceCount(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    aInvocation.InvocationReadEnd();
    uint32_t respaSourceCount;
    SourceCount(aVersion, respaSourceCount);
	aInvocation.InvocationWriteStart();
    InvocationResponseUint respWriteraSourceCount(aInvocation, "aSourceCount");
    respWriteraSourceCount.Write(respaSourceCount);
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoSourceIndex(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    aInvocation.InvocationReadEnd();
    uint32_t respaSourceIndex;
    SourceIndex(aVersion, respaSourceIndex);
	aInvocation.InvocationWriteStart();
    InvocationResponseUint respWriteraSourceIndex(aInvocation, "aSourceIndex");
    respWriteraSourceIndex.Write(respaSourceIndex);
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoSetSourceIndex(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    uint32_t aSourceIndex = aInvocation.InvocationReadUint("aSourceIndex");
    aInvocation.InvocationReadEnd();
    SetSourceIndex(aVersion, aSourceIndex);
	aInvocation.InvocationWriteStart();
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::DoSourceType(IDviInvocation& aInvocation, TUint aVersion)
{
    aInvocation.InvocationReadStart();
    uint32_t aSourceIndex = aInvocation.InvocationReadUint("aSourceIndex");
    aInvocation.InvocationReadEnd();
    std::string respaSourceType;
    SourceType(aVersion, aSourceIndex, respaSourceType);
	aInvocation.InvocationWriteStart();
    InvocationResponseString respWriteraSourceType(aInvocation, "aSourceType");
    Brn buf_aSourceType((const TByte*)respaSourceType.c_str(), (TUint)respaSourceType.length());
    respWriteraSourceType.Write(buf_aSourceType);
    aInvocation.InvocationWriteStringEnd("aSourceType");
	aInvocation.InvocationWriteEnd();
}

void DvProviderLinnCoUkProduct2Cpp::Type(uint32_t /*aVersion*/, std::string& /*aaType*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::Model(uint32_t /*aVersion*/, std::string& /*aaModel*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::Name(uint32_t /*aVersion*/, std::string& /*aaName*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::SetName(uint32_t /*aVersion*/, const std::string& /*aaName*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::Room(uint32_t /*aVersion*/, std::string& /*aaRoom*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::SetRoom(uint32_t /*aVersion*/, const std::string& /*aaRoom*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::Standby(uint32_t /*aVersion*/, bool& /*aaStandby*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::SetStandby(uint32_t /*aVersion*/, bool /*aaStandby*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::SourceCount(uint32_t /*aVersion*/, uint32_t& /*aaSourceCount*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::SourceIndex(uint32_t /*aVersion*/, uint32_t& /*aaSourceIndex*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::SetSourceIndex(uint32_t /*aVersion*/, uint32_t /*aaSourceIndex*/)
{
    ASSERTS();
}

void DvProviderLinnCoUkProduct2Cpp::SourceType(uint32_t /*aVersion*/, uint32_t /*aaSourceIndex*/, std::string& /*aaSourceType*/)
{
    ASSERTS();
}

