#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

struct Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA;
struct Dictionary_2_t8310586D40E281DE2C7E50F0594273A3DDCB38A7;
struct Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710;
struct Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83;
struct IEqualityComparer_1_tAE94C8F24AD5B94D4EE85CA9FC59E3409D41CAF7;
struct KeyCollection_tE66790F09E854C19C7F612BEAD203AE626E90A36;
struct KeyCollection_t2EDD317F5771E575ACB63527B5AFB71291040342;
struct List_1_tC6B5C6E3C0915B3ADCE4851E6AB17C943A3F51FA;
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD;
struct ValueCollection_tC9D91E8A3198E40EA339059703AB10DFC9F5CC2E;
struct ValueCollection_t238D0D2427C6B841A01F522A41540165A2C4AE76;
struct EntryU5BU5D_t233BB24ED01E2D8D65B0651D54B8E3AD125CAF96;
struct EntryU5BU5D_t1AF33AD0B7330843448956EC4277517081658AE7;
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
struct AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A;
struct IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA;
struct JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663;
struct JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B;
struct JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412;
struct JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97;
struct String_t;

IL2CPP_EXTERN_C RuntimeClass* AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Convert_t7097FF336D592F7C06D88A98349A44646F91EFFC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral05E4ED4BBD99C86DD56D953A9D396662EB0F131F;
IL2CPP_EXTERN_C String_t* _stringLiteral06AFF2D4AB1C22D067B63A6E037A3DB80AA69664;
IL2CPP_EXTERN_C String_t* _stringLiteral09F6BF5807F21976DC5A8B817678D0F3CA09B367;
IL2CPP_EXTERN_C String_t* _stringLiteral0C3C6829C3CCF8020C6AC45B87963ADC095CD44A;
IL2CPP_EXTERN_C String_t* _stringLiteral0E7889CA73C20C46B2F66AD10574288C6588120D;
IL2CPP_EXTERN_C String_t* _stringLiteral1192DB96DEDC8E4E93036F793E36461F6B1D708F;
IL2CPP_EXTERN_C String_t* _stringLiteral199406D22C247C128830321CCA0F0AA8B9EA8AF2;
IL2CPP_EXTERN_C String_t* _stringLiteral2492F08BCEBC6B4E86EA52B2DAFD8538DB7CCA9C;
IL2CPP_EXTERN_C String_t* _stringLiteral252C0671443017876C13A4B1405734D0B2A251E4;
IL2CPP_EXTERN_C String_t* _stringLiteral3D5ED547017EE65E294DEE1E52D286F1875F1660;
IL2CPP_EXTERN_C String_t* _stringLiteral4D8D9C94AC5DA5FCED2EC8A64E10E714A2515C30;
IL2CPP_EXTERN_C String_t* _stringLiteral587E53A8030FB45502AD4B59E2E80ED12683441E;
IL2CPP_EXTERN_C String_t* _stringLiteral58A74E1B0F0F661EA58D07F60FFEA6CB0362BA66;
IL2CPP_EXTERN_C String_t* _stringLiteral5C0B39AFA1D09BF84C4FF1412FDD072EBFBD3124;
IL2CPP_EXTERN_C String_t* _stringLiteral5ED04C43CC8F7FBE8FFFF015C5538190204F9C6B;
IL2CPP_EXTERN_C String_t* _stringLiteral5F02F365CDC640D33E644AC0D33DF8A23652EC84;
IL2CPP_EXTERN_C String_t* _stringLiteral62EEE5AB24B108CBF7AD1EA8323A060FA5C4FF46;
IL2CPP_EXTERN_C String_t* _stringLiteral69711252401E05EA08F1FC661CC7158162B64332;
IL2CPP_EXTERN_C String_t* _stringLiteral6C3D1606B345A91CAEF8856B890202C2FB91632A;
IL2CPP_EXTERN_C String_t* _stringLiteral79129E77C99D9B997190424687919AB33976D848;
IL2CPP_EXTERN_C String_t* _stringLiteral79FCA40744698D355AA21CA8D1C6D723796755E3;
IL2CPP_EXTERN_C String_t* _stringLiteral7D046F7A5E043071C26805C1E921D468CAB706D4;
IL2CPP_EXTERN_C String_t* _stringLiteral830861A7BE146B54573618AB59D51536353969C4;
IL2CPP_EXTERN_C String_t* _stringLiteral87E6B368D708695D844FB24A36D0437AFFE064A0;
IL2CPP_EXTERN_C String_t* _stringLiteral94FFD26B9FC865144CCBD5729EA8FAFF93163FB4;
IL2CPP_EXTERN_C String_t* _stringLiteral9ACD0102DF47E7CF98E660BDDEC79497C54A8EB3;
IL2CPP_EXTERN_C String_t* _stringLiteral9F85DBEFEA5FADBE3465375963EFAA0318BDEB3E;
IL2CPP_EXTERN_C String_t* _stringLiteralA333953DEB7B3F631AE4FEB93E9C3AD7F349F8C0;
IL2CPP_EXTERN_C String_t* _stringLiteralB3C02481F1EF6B21AC4FFB169F97120EA8E71309;
IL2CPP_EXTERN_C String_t* _stringLiteralB8EF4E6A277573B21FEDB39E4277FF8DB1D887E9;
IL2CPP_EXTERN_C String_t* _stringLiteralC122FD1744C24B2A4C733C7189953AF4AF702474;
IL2CPP_EXTERN_C String_t* _stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB;
IL2CPP_EXTERN_C String_t* _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677;
IL2CPP_EXTERN_C String_t* _stringLiteralCC3135654FE5454A443D0D19C37529E7EE6B1408;
IL2CPP_EXTERN_C String_t* _stringLiteralCCE359C6B0ABE9D58CB588667F9A93BA52A1C294;
IL2CPP_EXTERN_C String_t* _stringLiteralCCE5B17A5BD05AD9EF1BD09EF01F0A033B402D86;
IL2CPP_EXTERN_C String_t* _stringLiteralCCED2B25A49F5AB8A840818C053B996994270607;
IL2CPP_EXTERN_C String_t* _stringLiteralCD2BBB96A45582D9F6CF9CDB5E373B1C0C1ABE76;
IL2CPP_EXTERN_C String_t* _stringLiteralD4C9D2736EA3E360FBB7AB6F8774B3D92E886B12;
IL2CPP_EXTERN_C String_t* _stringLiteralD559C6D97E819D8E4EF7ACDC34C4E8D3DD314964;
IL2CPP_EXTERN_C String_t* _stringLiteralD5A3CA0977C7EAB9154A7C6E8BEA40D60065C347;
IL2CPP_EXTERN_C String_t* _stringLiteralD8A485D101F805D29BFCDD25C667CB04AD5CC888;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralE1FA7984F63F6132B83FB4302371499FCEE3AAE0;
IL2CPP_EXTERN_C String_t* _stringLiteralEC54F561E7F139CCBA98C2FC655446C34C074D4C;
IL2CPP_EXTERN_C String_t* _stringLiteralEE7F2E90C1A80816B11CAE0EA9389988CBD19F97;
IL2CPP_EXTERN_C String_t* _stringLiteralF64BAE12AD307231B0FE01E55EB3DE58705EAE36;
IL2CPP_EXTERN_C String_t* _stringLiteralF931DEE4A87FE21CBBACC583499FBCF32B68B467;
IL2CPP_EXTERN_C String_t* _stringLiteralFC0ADAE748048E8066A24C5A9E285FE94437F54C;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_m5875DF2ACE933D734119C088B2E7C9C63F49B443_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_GetEnumerator_mF5B5B00F670F3436AB3C07C0F64149501DEC2DBC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_mA86D965CB5F74CE8675B7995C61945BEB6E594CB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mC4F3DF292BAD88F4BF193C49CD689FAEBC4570A9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m592BCCE7B7933454DED2130C810F059F8D85B1D7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_mA7C78FC10B78BFFDD69A6E1CA050B42D48F8B53F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_mBB43E0B46CDCD47543052FDB890026C269E6D96E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_mDB47EEC4531D33B9C33FD2E70BA15E1535A0F3ED_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m143541DD8FBCD313E7554EA738FA813B8F4DB11A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_mFAD52D332201C947C95ECF69DAE5C3319CA654F1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Key_m01BD798AD7B3C3ABC6CFC7A4B9D7A410A0E8C066_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Value_m2052BF44A3FDE623D98B0E6B6E227B2900034235_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Value_m9B7CF8794FDED0F052A78AA57AC88C205BE6B8FD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_GetEnumerator_m7692B5F182858B7D5C72C920D09AD48738D1E70D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_m0E55ACFE8DAB0F44EDF10E9EDF26FD2B84B68122_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_m0DF3B826A745419D26A168689AEB4BE6F8698ECA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_m3E66C5AA84110E479EAF0DDBC518BDB9E45199D6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_mB475257F3012818AAA61B72B67DA701FACE716DC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_mE2C54C6AE9FC9F05BF44CD9D7D61DC6CD56E3E28_RuntimeMethod_var;

struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
struct Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710  : public RuntimeObject
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets;
	EntryU5BU5D_t233BB24ED01E2D8D65B0651D54B8E3AD125CAF96* ____entries;
	int32_t ____count;
	int32_t ____freeList;
	int32_t ____freeCount;
	int32_t ____version;
	RuntimeObject* ____comparer;
	KeyCollection_tE66790F09E854C19C7F612BEAD203AE626E90A36* ____keys;
	ValueCollection_tC9D91E8A3198E40EA339059703AB10DFC9F5CC2E* ____values;
	RuntimeObject* ____syncRoot;
};
struct Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83  : public RuntimeObject
{
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets;
	EntryU5BU5D_t1AF33AD0B7330843448956EC4277517081658AE7* ____entries;
	int32_t ____count;
	int32_t ____freeList;
	int32_t ____freeCount;
	int32_t ____version;
	RuntimeObject* ____comparer;
	KeyCollection_t2EDD317F5771E575ACB63527B5AFB71291040342* ____keys;
	ValueCollection_t238D0D2427C6B841A01F522A41540165A2C4AE76* ____values;
	RuntimeObject* ____syncRoot;
};
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D  : public RuntimeObject
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD  : public RuntimeObject
{
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ____items;
	int32_t ____size;
	int32_t ____version;
	RuntimeObject* ____syncRoot;
};
struct U3CPrivateImplementationDetailsU3E_t0F5473E849A5A5185A9F4C5246F0C32816C49FCA  : public RuntimeObject
{
};
struct AdjustUrlStrategyExtension_tECD39955BB10EF1D04968E4A26C04BB154353386  : public RuntimeObject
{
};
struct AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A  : public RuntimeObject
{
};
struct JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97  : public RuntimeObject
{
};
struct String_t  : public RuntimeObject
{
	int32_t ____stringLength;
	Il2CppChar ____firstChar;
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};
struct Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A 
{
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ____list;
	int32_t ____index;
	int32_t ____version;
	RuntimeObject* ____current;
};
struct Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1 
{
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ____list;
	int32_t ____index;
	int32_t ____version;
	String_t* ____current;
};
struct KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 
{
	RuntimeObject* ___key;
	RuntimeObject* ___value;
};
struct KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E 
{
	String_t* ___key;
	JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* ___value;
};
struct KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9 
{
	String_t* ___key;
	RuntimeObject* ___value;
};
struct Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01 
{
	bool ___hasValue;
	bool ___value;
};
struct Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 
{
	bool ___hasValue;
	double ___value;
};
struct Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28 
{
	bool ___hasValue;
	int32_t ___value;
};
struct Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17 
{
	bool ___hasValue;
	int64_t ___value;
};
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	bool ___m_value;
};
struct Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F 
{
	double ___m_value;
};
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2  : public ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F
{
};
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_pinvoke
{
};
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_com
{
};
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	int32_t ___m_value;
};
struct Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3 
{
	int64_t ___m_value;
};
struct JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663  : public JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97
{
	List_1_tC6B5C6E3C0915B3ADCE4851E6AB17C943A3F51FA* ___m_List;
};
struct JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B  : public JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97
{
	Dictionary_2_t8310586D40E281DE2C7E50F0594273A3DDCB38A7* ___m_Dict;
};
struct JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412  : public JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97
{
	String_t* ___m_Data;
};
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};
#pragma pack(push, tp, 1)
struct __StaticArrayInitTypeSizeU3D100_tDC8423CC5C7CA372EDC2E1057F6B312876A06068 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D100_tDC8423CC5C7CA372EDC2E1057F6B312876A06068__padding[100];
	};
};
#pragma pack(pop, tp)
#pragma pack(push, tp, 1)
struct __StaticArrayInitTypeSizeU3D2640_tC14163064B97F2227E571EBBC0DE58E42D2BDC5F 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D2640_tC14163064B97F2227E571EBBC0DE58E42D2BDC5F__padding[2640];
	};
};
#pragma pack(pop, tp)
#pragma pack(push, tp, 1)
struct __StaticArrayInitTypeSizeU3D4342_tD93B8023752F28B63298A32C912E8E89147DF9AF 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D4342_tD93B8023752F28B63298A32C912E8E89147DF9AF__padding[4342];
	};
};
#pragma pack(pop, tp)
struct Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9 
{
	Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* ____dictionary;
	int32_t ____version;
	int32_t ____index;
	KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 ____current;
	int32_t ____getEnumeratorRetType;
};
struct Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62 
{
	Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* ____dictionary;
	int32_t ____version;
	int32_t ____index;
	KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9 ____current;
	int32_t ____getEnumeratorRetType;
};
struct AdjustLogLevel_t9ECA708EA4C64BA5F834D6C17B6ED78B158DDE85 
{
	int32_t ___value__;
};
struct AdjustUrlStrategy_tD74FF5EF698F52FCDF175B556FFD32ABEE7BBBA0 
{
	int32_t ___value__;
};
struct Int32Enum_tCBAC8BA2BFF3A845FA599F303093BBBA374B6F0C 
{
	int32_t ___value__;
};
struct Nullable_1_tB5B55E6FB7CA2D587DD5769052FCD30C0E9C09F0 
{
	bool ___hasValue;
	int32_t ___value;
};
struct Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14 
{
	bool ___hasValue;
	int32_t ___value;
};
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_StaticFields
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___s_emptyArray;
};
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_StaticFields
{
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___s_emptyArray;
};
struct U3CPrivateImplementationDetailsU3E_t0F5473E849A5A5185A9F4C5246F0C32816C49FCA_StaticFields
{
	__StaticArrayInitTypeSizeU3D2640_tC14163064B97F2227E571EBBC0DE58E42D2BDC5F ___21FC54495A4A612B127A23927681F453EA3CE93B98E2FE654779CDFD518CCBAE;
	__StaticArrayInitTypeSizeU3D100_tDC8423CC5C7CA372EDC2E1057F6B312876A06068 ___8BE2DC00802A5AEAED417A8E1DC8D990EB6645C8B316C2EDCEFF730ADC80E931;
	__StaticArrayInitTypeSizeU3D100_tDC8423CC5C7CA372EDC2E1057F6B312876A06068 ___C3EF13061F5FA6E5555D3799B31E309475032938744227D505E91C2E82F2A61E;
	__StaticArrayInitTypeSizeU3D4342_tD93B8023752F28B63298A32C912E8E89147DF9AF ___C8435A7DAB8103E06223346911DA1EF23733280CD1F68006B562E51F01B9A3A9;
};
struct AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields
{
	String_t* ___KeyAdid;
	String_t* ___KeyMessage;
	String_t* ___KeyNetwork;
	String_t* ___KeyAdgroup;
	String_t* ___KeyCampaign;
	String_t* ___KeyCreative;
	String_t* ___KeyWillRetry;
	String_t* ___KeyTimestamp;
	String_t* ___KeyCallbackId;
	String_t* ___KeyEventToken;
	String_t* ___KeyClickLabel;
	String_t* ___KeyTrackerName;
	String_t* ___KeyTrackerToken;
	String_t* ___KeyJsonResponse;
	String_t* ___KeyCostType;
	String_t* ___KeyCostAmount;
	String_t* ___KeyCostCurrency;
	String_t* ___KeyFbInstallReferrer;
	String_t* ___KeySkadConversionValue;
	String_t* ___KeySkadCoarseValue;
	String_t* ___KeySkadLockWindow;
	String_t* ___KeyTestOptionsBaseUrl;
	String_t* ___KeyTestOptionsGdprUrl;
	String_t* ___KeyTestOptionsSubscriptionUrl;
	String_t* ___KeyTestOptionsExtraPath;
	String_t* ___KeyTestOptionsBasePath;
	String_t* ___KeyTestOptionsGdprPath;
	String_t* ___KeyTestOptionsDeleteState;
	String_t* ___KeyTestOptionsUseTestConnectionOptions;
	String_t* ___KeyTestOptionsTimerIntervalInMilliseconds;
	String_t* ___KeyTestOptionsTimerStartInMilliseconds;
	String_t* ___KeyTestOptionsSessionIntervalInMilliseconds;
	String_t* ___KeyTestOptionsSubsessionIntervalInMilliseconds;
	String_t* ___KeyTestOptionsTeardown;
	String_t* ___KeyTestOptionsNoBackoffWait;
	String_t* ___KeyTestOptionsiAdFrameworkEnabled;
	String_t* ___KeyTestOptionsAdServicesFrameworkEnabled;
};
struct String_t_StaticFields
{
	String_t* ___Empty;
};
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	String_t* ___TrueString;
	String_t* ___FalseString;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248  : public RuntimeArray
{
	ALIGN_FIELD (8) String_t* m_Items[1];

	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Nullable_1_get_Value_m0E81D9B6F2BA5FA17AA4366C5179CD09524FCB60_gshared (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_gshared_inline (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Nullable_1_get_Value_mE2C54C6AE9FC9F05BF44CD9D7D61DC6CD56E3E28_gshared (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_gshared_inline (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_gshared (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_gshared_inline (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Nullable_1_get_Value_m0DF3B826A745419D26A168689AEB4BE6F8698ECA_gshared (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_gshared_inline (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Nullable_1_get_Value_mB475257F3012818AAA61B72B67DA701FACE716DC_gshared (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___0_index, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9 Dictionary_2_GetEnumerator_m52AB12790B0B9B46B1DFB1F861C9DBEAB07C1FDA_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mEA5E01B81EB943B7003D87CEC1B6040524F0402C_gshared (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 Enumerator_get_Current_mE3475384B761E1C7971D3639BD09117FE8363422_gshared_inline (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) ;
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mCD4950A75FFADD54AF354D48C6C0DB0B5A22A5F4_gshared (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Add_m93FFFABE8FCE7FA9793F0915E2A8842C7CD0C0C1_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___0_key, RuntimeObject* ___1_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___0_key, RuntimeObject** ___1_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_NO_INLINE IL2CPP_METHOD_ATTR void List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;

inline bool Nullable_1_get_HasValue_m0E55ACFE8DAB0F44EDF10E9EDF26FD2B84B68122_inline (Nullable_1_tB5B55E6FB7CA2D587DD5769052FCD30C0E9C09F0* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_tB5B55E6FB7CA2D587DD5769052FCD30C0E9C09F0*, const RuntimeMethod*))Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline)(__this, method);
}
inline int32_t Nullable_1_get_Value_m3E66C5AA84110E479EAF0DDBC518BDB9E45199D6 (Nullable_1_tB5B55E6FB7CA2D587DD5769052FCD30C0E9C09F0* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Nullable_1_tB5B55E6FB7CA2D587DD5769052FCD30C0E9C09F0*, const RuntimeMethod*))Nullable_1_get_Value_m0E81D9B6F2BA5FA17AA4366C5179CD09524FCB60_gshared)(__this, method);
}
inline bool Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_inline (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01*, const RuntimeMethod*))Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_gshared_inline)(__this, method);
}
inline bool Nullable_1_get_Value_mE2C54C6AE9FC9F05BF44CD9D7D61DC6CD56E3E28 (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01*, const RuntimeMethod*))Nullable_1_get_Value_mE2C54C6AE9FC9F05BF44CD9D7D61DC6CD56E3E28_gshared)(__this, method);
}
inline bool Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_inline (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165*, const RuntimeMethod*))Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_gshared_inline)(__this, method);
}
inline double Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1 (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method)
{
	return ((  double (*) (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165*, const RuntimeMethod*))Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_gshared)(__this, method);
}
inline bool Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_inline (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28*, const RuntimeMethod*))Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_gshared_inline)(__this, method);
}
inline int32_t Nullable_1_get_Value_m0DF3B826A745419D26A168689AEB4BE6F8698ECA (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28*, const RuntimeMethod*))Nullable_1_get_Value_m0DF3B826A745419D26A168689AEB4BE6F8698ECA_gshared)(__this, method);
}
inline bool Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_inline (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17*, const RuntimeMethod*))Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_gshared_inline)(__this, method);
}
inline int64_t Nullable_1_get_Value_mB475257F3012818AAA61B72B67DA701FACE716DC (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17* __this, const RuntimeMethod* method)
{
	return ((  int64_t (*) (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17*, const RuntimeMethod*))Nullable_1_get_Value_mB475257F3012818AAA61B72B67DA701FACE716DC_gshared)(__this, method);
}
inline int32_t List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
inline void List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
inline String_t* List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8 (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, int32_t ___0_index, const RuntimeMethod* method)
{
	return ((  String_t* (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___0_index, method);
}
inline void List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, String_t* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, String_t*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JSONArray__ctor_m6ECA2300A22DEFC3387A72AF03FEC3355B150C4E (JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663* __this, const RuntimeMethod* method) ;
inline Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1 List_1_GetEnumerator_m7692B5F182858B7D5C72C920D09AD48738D1E70D (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1 (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, const RuntimeMethod*))List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared)(__this, method);
}
inline void Enumerator_Dispose_m592BCCE7B7933454DED2130C810F059F8D85B1D7 (Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1*, const RuntimeMethod*))Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared)(__this, method);
}
inline String_t* Enumerator_get_Current_m143541DD8FBCD313E7554EA738FA813B8F4DB11A_inline (Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1* __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1*, const RuntimeMethod*))Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JSONData__ctor_mF07078A36644CD1C44FD4394482FFF67BCCEEAC5 (JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412* __this, String_t* ___0_aData, const RuntimeMethod* method) ;
inline bool Enumerator_MoveNext_mDB47EEC4531D33B9C33FD2E70BA15E1535A0F3ED (Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1*, const RuntimeMethod*))Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9E3155FB84015C823606188F53B47CB44C444991 (String_t* ___0_str0, String_t* ___1_str1, const RuntimeMethod* method) ;
inline Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62 Dictionary_2_GetEnumerator_mF5B5B00F670F3436AB3C07C0F64149501DEC2DBC (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62 (*) (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710*, const RuntimeMethod*))Dictionary_2_GetEnumerator_m52AB12790B0B9B46B1DFB1F861C9DBEAB07C1FDA_gshared)(__this, method);
}
inline void Enumerator_Dispose_mA7C78FC10B78BFFDD69A6E1CA050B42D48F8B53F (Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62*, const RuntimeMethod*))Enumerator_Dispose_mEA5E01B81EB943B7003D87CEC1B6040524F0402C_gshared)(__this, method);
}
inline KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9 Enumerator_get_Current_mFAD52D332201C947C95ECF69DAE5C3319CA654F1_inline (Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62* __this, const RuntimeMethod* method)
{
	return ((  KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9 (*) (Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62*, const RuntimeMethod*))Enumerator_get_Current_mE3475384B761E1C7971D3639BD09117FE8363422_gshared_inline)(__this, method);
}
inline RuntimeObject* KeyValuePair_2_get_Value_m2052BF44A3FDE623D98B0E6B6E227B2900034235_inline (KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9* __this, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9*, const RuntimeMethod*))KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_StartsWith_mF75DBA1EB709811E711B44E26FF919C88A8E65C0 (String_t* __this, String_t* ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_EndsWith_mCD3754F5401E19CE7821CD398986E4EAA6AD87DC (String_t* __this, String_t* ___0_value, const RuntimeMethod* method) ;
inline String_t* KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_inline (KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9* __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9*, const RuntimeMethod*))KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m647EBF831F54B6DF7D5AFA5FD012CF4EE7571B6A (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___0_values, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m093934F71A9B351911EE46311674ED463B180006 (String_t* ___0_str0, String_t* ___1_str1, String_t* ___2_str2, String_t* ___3_str3, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUtils_GetJsonResponseCompact_mB1763C6F6A17665BAA0534CE919BCFB7D7D491F6 (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* ___0_dictionary, const RuntimeMethod* method) ;
inline bool Enumerator_MoveNext_mBB43E0B46CDCD47543052FDB890026C269E6D96E (Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62*, const RuntimeMethod*))Enumerator_MoveNext_mCD4950A75FFADD54AF354D48C6C0DB0B5A22A5F4_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634 (JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* ___0_a, RuntimeObject* ___1_b, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* JSONClass_GetEnumerator_mC63BF81FA10F977320F60BFF46CDA748A7F09DAD (JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* __this, const RuntimeMethod* method) ;
inline JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* KeyValuePair_2_get_Value_m9B7CF8794FDED0F052A78AA57AC88C205BE6B8FD_inline (KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E* __this, const RuntimeMethod* method)
{
	return ((  JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* (*) (KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E*, const RuntimeMethod*))KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline)(__this, method);
}
inline String_t* KeyValuePair_2_get_Key_m01BD798AD7B3C3ABC6CFC7A4B9D7A410A0E8C066_inline (KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E* __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E*, const RuntimeMethod*))KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline)(__this, method);
}
inline void Dictionary_2_Add_m5875DF2ACE933D734119C088B2E7C9C63F49B443 (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* __this, String_t* ___0_key, RuntimeObject* ___1_value, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710*, String_t*, RuntimeObject*, const RuntimeMethod*))Dictionary_2_Add_m93FFFABE8FCE7FA9793F0915E2A8842C7CD0C0C1_gshared)(__this, ___0_key, ___1_value, method);
}
inline void Dictionary_2__ctor_mC4F3DF292BAD88F4BF193C49CD689FAEBC4570A9 (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710*, const RuntimeMethod*))Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared)(__this, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AdjustUtils_WriteJsonResponseDictionary_m45C6F803D1190D8144D7E3441A4CF870606463ED (JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* ___0_jsonObject, Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* ___1_output, const RuntimeMethod* method) ;
inline bool Dictionary_2_TryGetValue_mA86D965CB5F74CE8675B7995C61945BEB6E594CB (Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* __this, String_t* ___0_key, String_t** ___1_value, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83*, String_t*, String_t**, const RuntimeMethod*))Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared)(__this, ___0_key, ___1_value, method);
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1 (String_t* ___0_a, String_t* ___1_b, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* JSON_Parse_m64D44E2E2DCDC73C4FC5A08B5D13F92209F2482E (String_t* ___0_aJSON, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUtils_GetJsonString_m7E4ABC127B656F2CF1D6D5C2973CCDC9345477A1 (JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* ___0_node, String_t* ___1_key, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Int32_TryParse_mC928DE2FEC1C35ED5298BDDCA9868076E94B8A21 (String_t* ___0_s, int32_t* ___1_result, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Convert_ToBoolean_m3DEA64CC166C14DD2B3461A04C227A05BC06DFEC (String_t* ___0_value, const RuntimeMethod* method) ;
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
inline void List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4 (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4_gshared)(__this, ___0_item, method);
}
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUrlStrategyExtension_ToLowerCaseString_mC501B171FABC8E81E217A019B01F9D079D4DC7A0 (int32_t ___0_strategy, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1192DB96DEDC8E4E93036F793E36461F6B1D708F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral58A74E1B0F0F661EA58D07F60FFEA6CB0362BA66);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral830861A7BE146B54573618AB59D51536353969C4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB8EF4E6A277573B21FEDB39E4277FF8DB1D887E9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCD2BBB96A45582D9F6CF9CDB5E373B1C0C1ABE76);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___0_strategy;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_0, 1)))
		{
			case 0:
			{
				goto IL_002a;
			}
			case 1:
			{
				goto IL_0030;
			}
			case 2:
			{
				goto IL_0036;
			}
			case 3:
			{
				goto IL_001e;
			}
			case 4:
			{
				goto IL_0024;
			}
		}
	}
	{
		goto IL_003c;
	}

IL_001e:
	{
		return _stringLiteral1192DB96DEDC8E4E93036F793E36461F6B1D708F;
	}

IL_0024:
	{
		return _stringLiteral830861A7BE146B54573618AB59D51536353969C4;
	}

IL_002a:
	{
		return _stringLiteralB8EF4E6A277573B21FEDB39E4277FF8DB1D887E9;
	}

IL_0030:
	{
		return _stringLiteral58A74E1B0F0F661EA58D07F60FFEA6CB0362BA66;
	}

IL_0036:
	{
		return _stringLiteralCD2BBB96A45582D9F6CF9CDB5E373B1C0C1ABE76;
	}

IL_003c:
	{
		String_t* L_1 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty;
		return L_1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AdjustUtils_ConvertLogLevel_mF7D0CB4C0B08008E37686670B7361871B737A53F (Nullable_1_tB5B55E6FB7CA2D587DD5769052FCD30C0E9C09F0 ___0_logLevel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_m0E55ACFE8DAB0F44EDF10E9EDF26FD2B84B68122_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_m3E66C5AA84110E479EAF0DDBC518BDB9E45199D6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0;
		L_0 = Nullable_1_get_HasValue_m0E55ACFE8DAB0F44EDF10E9EDF26FD2B84B68122_inline((&___0_logLevel), Nullable_1_get_HasValue_m0E55ACFE8DAB0F44EDF10E9EDF26FD2B84B68122_RuntimeMethod_var);
		if (L_0)
		{
			goto IL_000b;
		}
	}
	{
		return (-1);
	}

IL_000b:
	{
		int32_t L_1;
		L_1 = Nullable_1_get_Value_m3E66C5AA84110E479EAF0DDBC518BDB9E45199D6((&___0_logLevel), Nullable_1_get_Value_m3E66C5AA84110E479EAF0DDBC518BDB9E45199D6_RuntimeMethod_var);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AdjustUtils_ConvertBool_mBFC3BC841A003201C7056448C67C35625379E786 (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01 ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_mE2C54C6AE9FC9F05BF44CD9D7D61DC6CD56E3E28_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0;
		L_0 = Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_inline((&___0_value), Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_RuntimeMethod_var);
		if (L_0)
		{
			goto IL_000b;
		}
	}
	{
		return (-1);
	}

IL_000b:
	{
		bool L_1;
		L_1 = Nullable_1_get_Value_mE2C54C6AE9FC9F05BF44CD9D7D61DC6CD56E3E28((&___0_value), Nullable_1_get_Value_mE2C54C6AE9FC9F05BF44CD9D7D61DC6CD56E3E28_RuntimeMethod_var);
		if (!L_1)
		{
			goto IL_0016;
		}
	}
	{
		return 1;
	}

IL_0016:
	{
		return 0;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double AdjustUtils_ConvertDouble_m328F7E087047FA52AEF1D681FCCD32D80791B749 (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0;
		L_0 = Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_inline((&___0_value), Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		if (L_0)
		{
			goto IL_0013;
		}
	}
	{
		return (-1.0);
	}

IL_0013:
	{
		double L_1;
		L_1 = Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1((&___0_value), Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		return ((double)L_1);
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AdjustUtils_ConvertInt_mE9AACF8054BA25B7605B3F8727091ED4F41CF37C (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28 ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_m0DF3B826A745419D26A168689AEB4BE6F8698ECA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0;
		L_0 = Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_inline((&___0_value), Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_RuntimeMethod_var);
		if (L_0)
		{
			goto IL_000b;
		}
	}
	{
		return (-1);
	}

IL_000b:
	{
		int32_t L_1;
		L_1 = Nullable_1_get_Value_m0DF3B826A745419D26A168689AEB4BE6F8698ECA((&___0_value), Nullable_1_get_Value_m0DF3B826A745419D26A168689AEB4BE6F8698ECA_RuntimeMethod_var);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t AdjustUtils_ConvertLong_m7B66091ED09C4DA947FB5C61D5AC40762100FAF4 (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17 ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_mB475257F3012818AAA61B72B67DA701FACE716DC_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0;
		L_0 = Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_inline((&___0_value), Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_RuntimeMethod_var);
		if (L_0)
		{
			goto IL_000c;
		}
	}
	{
		return ((int64_t)(-1));
	}

IL_000c:
	{
		int64_t L_1;
		L_1 = Nullable_1_get_Value_mB475257F3012818AAA61B72B67DA701FACE716DC((&___0_value), Nullable_1_get_Value_mB475257F3012818AAA61B72B67DA701FACE716DC_RuntimeMethod_var);
		return L_1;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUtils_ConvertListToJson_m0834067B90DD8AA9713B0A395933C806BDB84689 (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___0_list, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m592BCCE7B7933454DED2130C810F059F8D85B1D7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_mDB47EEC4531D33B9C33FD2E70BA15E1535A0F3ED_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m143541DD8FBCD313E7554EA738FA813B8F4DB11A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_GetEnumerator_m7692B5F182858B7D5C72C920D09AD48738D1E70D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* V_0 = NULL;
	JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663* V_1 = NULL;
	int32_t V_2 = 0;
	String_t* V_3 = NULL;
	String_t* V_4 = NULL;
	Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1 V_5;
	memset((&V_5), 0, sizeof(V_5));
	String_t* V_6 = NULL;
	{
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_0 = ___0_list;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		return (String_t*)NULL;
	}

IL_0005:
	{
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_1 = ___0_list;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline(L_1, List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		if (!((int32_t)(L_2%2)))
		{
			goto IL_0011;
		}
	}
	{
		return (String_t*)NULL;
	}

IL_0011:
	{
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_3 = (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*)il2cpp_codegen_object_new(List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var);
		List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E(L_3, List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var);
		V_0 = L_3;
		V_2 = 0;
		goto IL_0048;
	}

IL_001b:
	{
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_4 = ___0_list;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		String_t* L_6;
		L_6 = List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8(L_4, L_5, List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		V_3 = L_6;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_7 = ___0_list;
		int32_t L_8 = V_2;
		NullCheck(L_7);
		String_t* L_9;
		L_9 = List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8(L_7, ((int32_t)il2cpp_codegen_add(L_8, 1)), List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		V_4 = L_9;
		String_t* L_10 = V_3;
		if (!L_10)
		{
			goto IL_0044;
		}
	}
	{
		String_t* L_11 = V_4;
		if (!L_11)
		{
			goto IL_0044;
		}
	}
	{
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_12 = V_0;
		String_t* L_13 = V_3;
		NullCheck(L_12);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_12, L_13, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_14 = V_0;
		String_t* L_15 = V_4;
		NullCheck(L_14);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_14, L_15, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
	}

IL_0044:
	{
		int32_t L_16 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_16, 2));
	}

IL_0048:
	{
		int32_t L_17 = V_2;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_18 = ___0_list;
		NullCheck(L_18);
		int32_t L_19;
		L_19 = List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline(L_18, List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		if ((((int32_t)L_17) < ((int32_t)L_19)))
		{
			goto IL_001b;
		}
	}
	{
		JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663* L_20 = (JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663*)il2cpp_codegen_object_new(JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663_il2cpp_TypeInfo_var);
		JSONArray__ctor_m6ECA2300A22DEFC3387A72AF03FEC3355B150C4E(L_20, NULL);
		V_1 = L_20;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_21 = V_0;
		NullCheck(L_21);
		Enumerator_tA7A4B718FE1ED1D87565680D8C8195EC8AEAB3D1 L_22;
		L_22 = List_1_GetEnumerator_m7692B5F182858B7D5C72C920D09AD48738D1E70D(L_21, List_1_GetEnumerator_m7692B5F182858B7D5C72C920D09AD48738D1E70D_RuntimeMethod_var);
		V_5 = L_22;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0082:
			{
				Enumerator_Dispose_m592BCCE7B7933454DED2130C810F059F8D85B1D7((&V_5), Enumerator_Dispose_m592BCCE7B7933454DED2130C810F059F8D85B1D7_RuntimeMethod_var);
				return;
			}
		});
		try
		{
			{
				goto IL_0077_1;
			}

IL_0061_1:
			{
				String_t* L_23;
				L_23 = Enumerator_get_Current_m143541DD8FBCD313E7554EA738FA813B8F4DB11A_inline((&V_5), Enumerator_get_Current_m143541DD8FBCD313E7554EA738FA813B8F4DB11A_RuntimeMethod_var);
				V_6 = L_23;
				JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663* L_24 = V_1;
				String_t* L_25 = V_6;
				JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412* L_26 = (JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412*)il2cpp_codegen_object_new(JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412_il2cpp_TypeInfo_var);
				JSONData__ctor_mF07078A36644CD1C44FD4394482FFF67BCCEEAC5(L_26, L_25, NULL);
				NullCheck(L_24);
				VirtualActionInvoker1< JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* >::Invoke(12, L_24, L_26);
			}

IL_0077_1:
			{
				bool L_27;
				L_27 = Enumerator_MoveNext_mDB47EEC4531D33B9C33FD2E70BA15E1535A0F3ED((&V_5), Enumerator_MoveNext_mDB47EEC4531D33B9C33FD2E70BA15E1535A0F3ED_RuntimeMethod_var);
				if (L_27)
				{
					goto IL_0061_1;
				}
			}
			{
				goto IL_0090;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0090:
	{
		JSONArray_t5159798EB689FADFF1A5BA9E65AAD070152CC663* L_28 = V_1;
		NullCheck(L_28);
		String_t* L_29;
		L_29 = VirtualFuncInvoker0< String_t* >::Invoke(3, L_28);
		return L_29;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUtils_GetJsonResponseCompact_mB1763C6F6A17665BAA0534CE919BCFB7D7D491F6 (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* ___0_dictionary, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_GetEnumerator_mF5B5B00F670F3436AB3C07C0F64149501DEC2DBC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_mA7C78FC10B78BFFDD69A6E1CA050B42D48F8B53F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_mBB43E0B46CDCD47543052FDB890026C269E6D96E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_mFAD52D332201C947C95ECF69DAE5C3319CA654F1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Value_m2052BF44A3FDE623D98B0E6B6E227B2900034235_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0C3C6829C3CCF8020C6AC45B87963ADC095CD44A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4D8D9C94AC5DA5FCED2EC8A64E10E714A2515C30);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA333953DEB7B3F631AE4FEB93E9C3AD7F349F8C0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE1FA7984F63F6132B83FB4302371499FCEE3AAE0);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62 V_2;
	memset((&V_2), 0, sizeof(V_2));
	KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9 V_3;
	memset((&V_3), 0, sizeof(V_3));
	String_t* V_4 = NULL;
	Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* V_5 = NULL;
	{
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_0 = ___0_dictionary;
		if (L_0)
		{
			goto IL_000b;
		}
	}
	{
		String_t* L_1 = V_0;
		return L_1;
	}

IL_000b:
	{
		V_1 = 0;
		String_t* L_2 = V_0;
		String_t* L_3;
		L_3 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_2, _stringLiteral0C3C6829C3CCF8020C6AC45B87963ADC095CD44A, NULL);
		V_0 = L_3;
		Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_4 = ___0_dictionary;
		NullCheck(L_4);
		Enumerator_t06A9DDA7FA9EA8BC40458E628EBAF7B3AA14EB62 L_5;
		L_5 = Dictionary_2_GetEnumerator_mF5B5B00F670F3436AB3C07C0F64149501DEC2DBC(L_4, Dictionary_2_GetEnumerator_mF5B5B00F670F3436AB3C07C0F64149501DEC2DBC_RuntimeMethod_var);
		V_2 = L_5;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0135:
			{
				Enumerator_Dispose_mA7C78FC10B78BFFDD69A6E1CA050B42D48F8B53F((&V_2), Enumerator_Dispose_mA7C78FC10B78BFFDD69A6E1CA050B42D48F8B53F_RuntimeMethod_var);
				return;
			}
		});
		try
		{
			{
				goto IL_0127_1;
			}

IL_0025_1:
			{
				KeyValuePair_2_tBEE55F2A4574C64393155C322376FD98C7BFC7B9 L_6;
				L_6 = Enumerator_get_Current_mFAD52D332201C947C95ECF69DAE5C3319CA654F1_inline((&V_2), Enumerator_get_Current_mFAD52D332201C947C95ECF69DAE5C3319CA654F1_RuntimeMethod_var);
				V_3 = L_6;
				RuntimeObject* L_7;
				L_7 = KeyValuePair_2_get_Value_m2052BF44A3FDE623D98B0E6B6E227B2900034235_inline((&V_3), KeyValuePair_2_get_Value_m2052BF44A3FDE623D98B0E6B6E227B2900034235_RuntimeMethod_var);
				V_4 = ((String_t*)IsInstSealed((RuntimeObject*)L_7, String_t_il2cpp_TypeInfo_var));
				String_t* L_8 = V_4;
				if (!L_8)
				{
					goto IL_00df_1;
				}
			}
			{
				int32_t L_9 = V_1;
				int32_t L_10 = ((int32_t)il2cpp_codegen_add(L_9, 1));
				V_1 = L_10;
				if ((((int32_t)L_10) <= ((int32_t)1)))
				{
					goto IL_0056_1;
				}
			}
			{
				String_t* L_11 = V_0;
				String_t* L_12;
				L_12 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_11, _stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB, NULL);
				V_0 = L_12;
			}

IL_0056_1:
			{
				String_t* L_13 = V_4;
				NullCheck(L_13);
				bool L_14;
				L_14 = String_StartsWith_mF75DBA1EB709811E711B44E26FF919C88A8E65C0(L_13, _stringLiteral0C3C6829C3CCF8020C6AC45B87963ADC095CD44A, NULL);
				if (!L_14)
				{
					goto IL_00a6_1;
				}
			}
			{
				String_t* L_15 = V_4;
				NullCheck(L_15);
				bool L_16;
				L_16 = String_EndsWith_mCD3754F5401E19CE7821CD398986E4EAA6AD87DC(L_15, _stringLiteral4D8D9C94AC5DA5FCED2EC8A64E10E714A2515C30, NULL);
				if (!L_16)
				{
					goto IL_00a6_1;
				}
			}
			{
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_17 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)5);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_18 = L_17;
				String_t* L_19 = V_0;
				NullCheck(L_18);
				(L_18)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_19);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_20 = L_18;
				NullCheck(L_20);
				(L_20)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_21 = L_20;
				String_t* L_22;
				L_22 = KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_inline((&V_3), KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_RuntimeMethod_var);
				NullCheck(L_21);
				(L_21)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)L_22);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_23 = L_21;
				NullCheck(L_23);
				(L_23)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)_stringLiteralA333953DEB7B3F631AE4FEB93E9C3AD7F349F8C0);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_24 = L_23;
				String_t* L_25 = V_4;
				NullCheck(L_24);
				(L_24)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)L_25);
				String_t* L_26;
				L_26 = String_Concat_m647EBF831F54B6DF7D5AFA5FD012CF4EE7571B6A(L_24, NULL);
				V_0 = L_26;
				goto IL_0127_1;
			}

IL_00a6_1:
			{
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_27 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)6);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_28 = L_27;
				String_t* L_29 = V_0;
				NullCheck(L_28);
				(L_28)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_29);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_30 = L_28;
				NullCheck(L_30);
				(L_30)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_31 = L_30;
				String_t* L_32;
				L_32 = KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_inline((&V_3), KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_RuntimeMethod_var);
				NullCheck(L_31);
				(L_31)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)L_32);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_33 = L_31;
				NullCheck(L_33);
				(L_33)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)_stringLiteralE1FA7984F63F6132B83FB4302371499FCEE3AAE0);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_34 = L_33;
				String_t* L_35 = V_4;
				NullCheck(L_34);
				(L_34)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)L_35);
				StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_36 = L_34;
				NullCheck(L_36);
				(L_36)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
				String_t* L_37;
				L_37 = String_Concat_m647EBF831F54B6DF7D5AFA5FD012CF4EE7571B6A(L_36, NULL);
				V_0 = L_37;
				goto IL_0127_1;
			}

IL_00df_1:
			{
				RuntimeObject* L_38;
				L_38 = KeyValuePair_2_get_Value_m2052BF44A3FDE623D98B0E6B6E227B2900034235_inline((&V_3), KeyValuePair_2_get_Value_m2052BF44A3FDE623D98B0E6B6E227B2900034235_RuntimeMethod_var);
				V_5 = ((Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710*)IsInstClass((RuntimeObject*)L_38, Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710_il2cpp_TypeInfo_var));
				int32_t L_39 = V_1;
				int32_t L_40 = ((int32_t)il2cpp_codegen_add(L_39, 1));
				V_1 = L_40;
				if ((((int32_t)L_40) <= ((int32_t)1)))
				{
					goto IL_0101_1;
				}
			}
			{
				String_t* L_41 = V_0;
				String_t* L_42;
				L_42 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_41, _stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB, NULL);
				V_0 = L_42;
			}

IL_0101_1:
			{
				String_t* L_43 = V_0;
				String_t* L_44;
				L_44 = KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_inline((&V_3), KeyValuePair_2_get_Key_mA64FF29A08423140758B0276333D1A89C71B793A_RuntimeMethod_var);
				String_t* L_45;
				L_45 = String_Concat_m093934F71A9B351911EE46311674ED463B180006(L_43, _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677, L_44, _stringLiteralA333953DEB7B3F631AE4FEB93E9C3AD7F349F8C0, NULL);
				V_0 = L_45;
				String_t* L_46 = V_0;
				Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_47 = V_5;
				il2cpp_codegen_runtime_class_init_inline(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
				String_t* L_48;
				L_48 = AdjustUtils_GetJsonResponseCompact_mB1763C6F6A17665BAA0534CE919BCFB7D7D491F6(L_47, NULL);
				String_t* L_49;
				L_49 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_46, L_48, NULL);
				V_0 = L_49;
			}

IL_0127_1:
			{
				bool L_50;
				L_50 = Enumerator_MoveNext_mBB43E0B46CDCD47543052FDB890026C269E6D96E((&V_2), Enumerator_MoveNext_mBB43E0B46CDCD47543052FDB890026C269E6D96E_RuntimeMethod_var);
				if (L_50)
				{
					goto IL_0025_1;
				}
			}
			{
				goto IL_0143;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0143:
	{
		String_t* L_51 = V_0;
		String_t* L_52;
		L_52 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_51, _stringLiteral4D8D9C94AC5DA5FCED2EC8A64E10E714A2515C30, NULL);
		V_0 = L_52;
		String_t* L_53 = V_0;
		return L_53;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUtils_GetJsonString_m7E4ABC127B656F2CF1D6D5C2973CCDC9345477A1 (JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* ___0_node, String_t* ___1_key, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412* V_0 = NULL;
	{
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_0 = ___0_node;
		bool L_1;
		L_1 = JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634(L_0, NULL, NULL);
		if (!L_1)
		{
			goto IL_000b;
		}
	}
	{
		return (String_t*)NULL;
	}

IL_000b:
	{
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_2 = ___0_node;
		String_t* L_3 = ___1_key;
		NullCheck(L_2);
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_4;
		L_4 = VirtualFuncInvoker1< JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97*, String_t* >::Invoke(7, L_2, L_3);
		V_0 = ((JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412*)IsInstClass((RuntimeObject*)L_4, JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412_il2cpp_TypeInfo_var));
		JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412* L_5 = V_0;
		bool L_6;
		L_6 = JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634(L_5, NULL, NULL);
		if (!L_6)
		{
			goto IL_0023;
		}
	}
	{
		return (String_t*)NULL;
	}

IL_0023:
	{
		JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412* L_7 = V_0;
		bool L_8;
		L_8 = JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634(L_7, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, NULL);
		if (!L_8)
		{
			goto IL_0032;
		}
	}
	{
		return (String_t*)NULL;
	}

IL_0032:
	{
		JSONData_t7E8A504C9072A28C852BB209E0DE7E3DA1161412* L_9 = V_0;
		NullCheck(L_9);
		String_t* L_10;
		L_10 = VirtualFuncInvoker0< String_t* >::Invoke(9, L_9);
		return L_10;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AdjustUtils_WriteJsonResponseDictionary_m45C6F803D1190D8144D7E3441A4CF870606463ED (JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* ___0_jsonObject, Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* ___1_output, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_m5875DF2ACE933D734119C088B2E7C9C63F49B443_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mC4F3DF292BAD88F4BF193C49CD689FAEBC4570A9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Key_m01BD798AD7B3C3ABC6CFC7A4B9D7A410A0E8C066_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Value_m9B7CF8794FDED0F052A78AA57AC88C205BE6B8FD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E V_1;
	memset((&V_1), 0, sizeof(V_1));
	JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* V_2 = NULL;
	String_t* V_3 = NULL;
	Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* V_4 = NULL;
	String_t* V_5 = NULL;
	RuntimeObject* V_6 = NULL;
	{
		JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* L_0 = ___0_jsonObject;
		NullCheck(L_0);
		RuntimeObject* L_1;
		L_1 = JSONClass_GetEnumerator_mC63BF81FA10F977320F60BFF46CDA748A7F09DAD(L_0, NULL);
		V_0 = L_1;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_006e:
			{
				{
					RuntimeObject* L_2 = V_0;
					V_6 = ((RuntimeObject*)IsInst((RuntimeObject*)L_2, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var));
					RuntimeObject* L_3 = V_6;
					if (!L_3)
					{
						goto IL_0081;
					}
				}
				{
					RuntimeObject* L_4 = V_6;
					NullCheck(L_4);
					InterfaceActionInvoker0::Invoke(0, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_4);
				}

IL_0081:
				{
					return;
				}
			}
		});
		try
		{
			{
				goto IL_0064_1;
			}

IL_0009_1:
			{
				RuntimeObject* L_5 = V_0;
				NullCheck(L_5);
				RuntimeObject* L_6;
				L_6 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(1, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_5);
				V_1 = ((*(KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E*)((KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E*)(KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E*)UnBox(L_6, KeyValuePair_2_t4DCC69D7653407AEFEEBFEED308DEAD714A01F6E_il2cpp_TypeInfo_var))));
				JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_7;
				L_7 = KeyValuePair_2_get_Value_m9B7CF8794FDED0F052A78AA57AC88C205BE6B8FD_inline((&V_1), KeyValuePair_2_get_Value_m9B7CF8794FDED0F052A78AA57AC88C205BE6B8FD_RuntimeMethod_var);
				NullCheck(L_7);
				JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* L_8;
				L_8 = VirtualFuncInvoker0< JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* >::Invoke(27, L_7);
				V_2 = L_8;
				String_t* L_9;
				L_9 = KeyValuePair_2_get_Key_m01BD798AD7B3C3ABC6CFC7A4B9D7A410A0E8C066_inline((&V_1), KeyValuePair_2_get_Key_m01BD798AD7B3C3ABC6CFC7A4B9D7A410A0E8C066_RuntimeMethod_var);
				V_3 = L_9;
				JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* L_10 = V_2;
				bool L_11;
				L_11 = JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634(L_10, NULL, NULL);
				if (!L_11)
				{
					goto IL_004c_1;
				}
			}
			{
				JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_12;
				L_12 = KeyValuePair_2_get_Value_m9B7CF8794FDED0F052A78AA57AC88C205BE6B8FD_inline((&V_1), KeyValuePair_2_get_Value_m9B7CF8794FDED0F052A78AA57AC88C205BE6B8FD_RuntimeMethod_var);
				NullCheck(L_12);
				String_t* L_13;
				L_13 = VirtualFuncInvoker0< String_t* >::Invoke(9, L_12);
				V_5 = L_13;
				Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_14 = ___1_output;
				String_t* L_15 = V_3;
				String_t* L_16 = V_5;
				NullCheck(L_14);
				Dictionary_2_Add_m5875DF2ACE933D734119C088B2E7C9C63F49B443(L_14, L_15, L_16, Dictionary_2_Add_m5875DF2ACE933D734119C088B2E7C9C63F49B443_RuntimeMethod_var);
				goto IL_0064_1;
			}

IL_004c_1:
			{
				Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_17 = (Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710*)il2cpp_codegen_object_new(Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710_il2cpp_TypeInfo_var);
				Dictionary_2__ctor_mC4F3DF292BAD88F4BF193C49CD689FAEBC4570A9(L_17, Dictionary_2__ctor_mC4F3DF292BAD88F4BF193C49CD689FAEBC4570A9_RuntimeMethod_var);
				V_4 = L_17;
				Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_18 = ___1_output;
				String_t* L_19 = V_3;
				Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_20 = V_4;
				NullCheck(L_18);
				Dictionary_2_Add_m5875DF2ACE933D734119C088B2E7C9C63F49B443(L_18, L_19, L_20, Dictionary_2_Add_m5875DF2ACE933D734119C088B2E7C9C63F49B443_RuntimeMethod_var);
				JSONClass_t42103CB1D51E3167BF9750407778639AAD7D719B* L_21 = V_2;
				Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* L_22 = V_4;
				il2cpp_codegen_runtime_class_init_inline(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
				AdjustUtils_WriteJsonResponseDictionary_m45C6F803D1190D8144D7E3441A4CF870606463ED(L_21, L_22, NULL);
			}

IL_0064_1:
			{
				RuntimeObject* L_23 = V_0;
				NullCheck(L_23);
				bool L_24;
				L_24 = InterfaceFuncInvoker0< bool >::Invoke(0, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_23);
				if (L_24)
				{
					goto IL_0009_1;
				}
			}
			{
				goto IL_0082;
			}
		}
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0082:
	{
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUtils_TryGetValue_m3BF1818C3435B2DD8794C6BF52073DE2D50A57E9 (Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___0_dictionary, String_t* ___1_key, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_mA86D965CB5F74CE8675B7995C61945BEB6E594CB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_0 = ___0_dictionary;
		String_t* L_1 = ___1_key;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_TryGetValue_mA86D965CB5F74CE8675B7995C61945BEB6E594CB(L_0, L_1, (&V_0), Dictionary_2_TryGetValue_mA86D965CB5F74CE8675B7995C61945BEB6E594CB_RuntimeMethod_var);
		if (!L_2)
		{
			goto IL_001c;
		}
	}
	{
		String_t* L_3 = V_0;
		bool L_4;
		L_4 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_3, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, NULL);
		if (!L_4)
		{
			goto IL_001a;
		}
	}
	{
		return (String_t*)NULL;
	}

IL_001a:
	{
		String_t* L_5 = V_0;
		return L_5;
	}

IL_001c:
	{
		return (String_t*)NULL;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AdjustUtils_GetSkad4ConversionValue_mF1B95F499F7AECC0987FA3A4DD57E10F9582741E (String_t* ___0_conversionValueUpdate, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* V_0 = NULL;
	int32_t V_1 = 0;
	{
		String_t* L_0 = ___0_conversionValueUpdate;
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_1;
		L_1 = JSON_Parse_m64D44E2E2DCDC73C4FC5A08B5D13F92209F2482E(L_0, NULL);
		V_0 = L_1;
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_2 = V_0;
		bool L_3;
		L_3 = JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634(L_2, NULL, NULL);
		if (!L_3)
		{
			goto IL_0012;
		}
	}
	{
		return (-1);
	}

IL_0012:
	{
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_4 = V_0;
		il2cpp_codegen_runtime_class_init_inline(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		String_t* L_5 = ((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadConversionValue;
		String_t* L_6;
		L_6 = AdjustUtils_GetJsonString_m7E4ABC127B656F2CF1D6D5C2973CCDC9345477A1(L_4, L_5, NULL);
		V_1 = 0;
		bool L_7;
		L_7 = Int32_TryParse_mC928DE2FEC1C35ED5298BDDCA9868076E94B8A21(L_6, (&V_1), NULL);
		if (!L_7)
		{
			goto IL_002a;
		}
	}
	{
		int32_t L_8 = V_1;
		return L_8;
	}

IL_002a:
	{
		return (-1);
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AdjustUtils_GetSkad4CoarseValue_m6A96D9597EAAD2D606A7B8730683A1870E324FCA (String_t* ___0_conversionValueUpdate, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* V_0 = NULL;
	{
		String_t* L_0 = ___0_conversionValueUpdate;
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_1;
		L_1 = JSON_Parse_m64D44E2E2DCDC73C4FC5A08B5D13F92209F2482E(L_0, NULL);
		V_0 = L_1;
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_2 = V_0;
		bool L_3;
		L_3 = JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634(L_2, NULL, NULL);
		if (!L_3)
		{
			goto IL_0012;
		}
	}
	{
		return (String_t*)NULL;
	}

IL_0012:
	{
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_4 = V_0;
		il2cpp_codegen_runtime_class_init_inline(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		String_t* L_5 = ((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadCoarseValue;
		String_t* L_6;
		L_6 = AdjustUtils_GetJsonString_m7E4ABC127B656F2CF1D6D5C2973CCDC9345477A1(L_4, L_5, NULL);
		return L_6;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AdjustUtils_GetSkad4LockWindow_mE9E55E3A5B683CDF1BF463568133655A4BEEA39C (String_t* ___0_conversionValueUpdate, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_t7097FF336D592F7C06D88A98349A44646F91EFFC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* V_0 = NULL;
	{
		String_t* L_0 = ___0_conversionValueUpdate;
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_1;
		L_1 = JSON_Parse_m64D44E2E2DCDC73C4FC5A08B5D13F92209F2482E(L_0, NULL);
		V_0 = L_1;
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_2 = V_0;
		bool L_3;
		L_3 = JSONNode_op_Equality_mF53AB65ABCF70E4C7D035DF059648FED12577634(L_2, NULL, NULL);
		if (!L_3)
		{
			goto IL_0012;
		}
	}
	{
		return (bool)0;
	}

IL_0012:
	{
		JSONNode_tC53BF5744519F4E94EEFA09E2186A2783A560D97* L_4 = V_0;
		il2cpp_codegen_runtime_class_init_inline(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		String_t* L_5 = ((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadLockWindow;
		String_t* L_6;
		L_6 = AdjustUtils_GetJsonString_m7E4ABC127B656F2CF1D6D5C2973CCDC9345477A1(L_4, L_5, NULL);
		il2cpp_codegen_runtime_class_init_inline(Convert_t7097FF336D592F7C06D88A98349A44646F91EFFC_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Convert_ToBoolean_m3DEA64CC166C14DD2B3461A04C227A05BC06DFEC(L_6, NULL);
		return L_7;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AdjustUtils__ctor_mEE74F3B9A26BAE12B3C426FF63604FD7396544A2 (AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AdjustUtils__cctor_m4489DD780E5669549E8C7EDAF985BDEC7AC456E1 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral05E4ED4BBD99C86DD56D953A9D396662EB0F131F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral06AFF2D4AB1C22D067B63A6E037A3DB80AA69664);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral09F6BF5807F21976DC5A8B817678D0F3CA09B367);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0E7889CA73C20C46B2F66AD10574288C6588120D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral199406D22C247C128830321CCA0F0AA8B9EA8AF2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2492F08BCEBC6B4E86EA52B2DAFD8538DB7CCA9C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral252C0671443017876C13A4B1405734D0B2A251E4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3D5ED547017EE65E294DEE1E52D286F1875F1660);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral587E53A8030FB45502AD4B59E2E80ED12683441E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5C0B39AFA1D09BF84C4FF1412FDD072EBFBD3124);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5ED04C43CC8F7FBE8FFFF015C5538190204F9C6B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5F02F365CDC640D33E644AC0D33DF8A23652EC84);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral62EEE5AB24B108CBF7AD1EA8323A060FA5C4FF46);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral69711252401E05EA08F1FC661CC7158162B64332);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6C3D1606B345A91CAEF8856B890202C2FB91632A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral79129E77C99D9B997190424687919AB33976D848);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral79FCA40744698D355AA21CA8D1C6D723796755E3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7D046F7A5E043071C26805C1E921D468CAB706D4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral87E6B368D708695D844FB24A36D0437AFFE064A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral94FFD26B9FC865144CCBD5729EA8FAFF93163FB4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9ACD0102DF47E7CF98E660BDDEC79497C54A8EB3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9F85DBEFEA5FADBE3465375963EFAA0318BDEB3E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB3C02481F1EF6B21AC4FFB169F97120EA8E71309);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC122FD1744C24B2A4C733C7189953AF4AF702474);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCC3135654FE5454A443D0D19C37529E7EE6B1408);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCCE359C6B0ABE9D58CB588667F9A93BA52A1C294);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCCE5B17A5BD05AD9EF1BD09EF01F0A033B402D86);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCCED2B25A49F5AB8A840818C053B996994270607);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD4C9D2736EA3E360FBB7AB6F8774B3D92E886B12);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD559C6D97E819D8E4EF7ACDC34C4E8D3DD314964);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD5A3CA0977C7EAB9154A7C6E8BEA40D60065C347);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD8A485D101F805D29BFCDD25C667CB04AD5CC888);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEC54F561E7F139CCBA98C2FC655446C34C074D4C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEE7F2E90C1A80816B11CAE0EA9389988CBD19F97);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF64BAE12AD307231B0FE01E55EB3DE58705EAE36);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF931DEE4A87FE21CBBACC583499FBCF32B68B467);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFC0ADAE748048E8066A24C5A9E285FE94437F54C);
		s_Il2CppMethodInitialized = true;
	}
	{
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyAdid = _stringLiteral87E6B368D708695D844FB24A36D0437AFFE064A0;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyAdid), (void*)_stringLiteral87E6B368D708695D844FB24A36D0437AFFE064A0);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyMessage = _stringLiteralD559C6D97E819D8E4EF7ACDC34C4E8D3DD314964;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyMessage), (void*)_stringLiteralD559C6D97E819D8E4EF7ACDC34C4E8D3DD314964);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyNetwork = _stringLiteral199406D22C247C128830321CCA0F0AA8B9EA8AF2;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyNetwork), (void*)_stringLiteral199406D22C247C128830321CCA0F0AA8B9EA8AF2);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyAdgroup = _stringLiteral252C0671443017876C13A4B1405734D0B2A251E4;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyAdgroup), (void*)_stringLiteral252C0671443017876C13A4B1405734D0B2A251E4);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCampaign = _stringLiteral2492F08BCEBC6B4E86EA52B2DAFD8538DB7CCA9C;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCampaign), (void*)_stringLiteral2492F08BCEBC6B4E86EA52B2DAFD8538DB7CCA9C);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCreative = _stringLiteral3D5ED547017EE65E294DEE1E52D286F1875F1660;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCreative), (void*)_stringLiteral3D5ED547017EE65E294DEE1E52D286F1875F1660);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyWillRetry = _stringLiteralC122FD1744C24B2A4C733C7189953AF4AF702474;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyWillRetry), (void*)_stringLiteralC122FD1744C24B2A4C733C7189953AF4AF702474);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTimestamp = _stringLiteralCCE359C6B0ABE9D58CB588667F9A93BA52A1C294;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTimestamp), (void*)_stringLiteralCCE359C6B0ABE9D58CB588667F9A93BA52A1C294);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCallbackId = _stringLiteral69711252401E05EA08F1FC661CC7158162B64332;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCallbackId), (void*)_stringLiteral69711252401E05EA08F1FC661CC7158162B64332);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyEventToken = _stringLiteral79129E77C99D9B997190424687919AB33976D848;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyEventToken), (void*)_stringLiteral79129E77C99D9B997190424687919AB33976D848);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyClickLabel = _stringLiteral0E7889CA73C20C46B2F66AD10574288C6588120D;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyClickLabel), (void*)_stringLiteral0E7889CA73C20C46B2F66AD10574288C6588120D);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTrackerName = _stringLiteral5C0B39AFA1D09BF84C4FF1412FDD072EBFBD3124;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTrackerName), (void*)_stringLiteral5C0B39AFA1D09BF84C4FF1412FDD072EBFBD3124);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTrackerToken = _stringLiteral5ED04C43CC8F7FBE8FFFF015C5538190204F9C6B;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTrackerToken), (void*)_stringLiteral5ED04C43CC8F7FBE8FFFF015C5538190204F9C6B);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyJsonResponse = _stringLiteral9ACD0102DF47E7CF98E660BDDEC79497C54A8EB3;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyJsonResponse), (void*)_stringLiteral9ACD0102DF47E7CF98E660BDDEC79497C54A8EB3);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCostType = _stringLiteral587E53A8030FB45502AD4B59E2E80ED12683441E;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCostType), (void*)_stringLiteral587E53A8030FB45502AD4B59E2E80ED12683441E);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCostAmount = _stringLiteralD5A3CA0977C7EAB9154A7C6E8BEA40D60065C347;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCostAmount), (void*)_stringLiteralD5A3CA0977C7EAB9154A7C6E8BEA40D60065C347);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCostCurrency = _stringLiteralEE7F2E90C1A80816B11CAE0EA9389988CBD19F97;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyCostCurrency), (void*)_stringLiteralEE7F2E90C1A80816B11CAE0EA9389988CBD19F97);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyFbInstallReferrer = _stringLiteral06AFF2D4AB1C22D067B63A6E037A3DB80AA69664;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyFbInstallReferrer), (void*)_stringLiteral06AFF2D4AB1C22D067B63A6E037A3DB80AA69664);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadConversionValue = _stringLiteral6C3D1606B345A91CAEF8856B890202C2FB91632A;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadConversionValue), (void*)_stringLiteral6C3D1606B345A91CAEF8856B890202C2FB91632A);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadCoarseValue = _stringLiteral94FFD26B9FC865144CCBD5729EA8FAFF93163FB4;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadCoarseValue), (void*)_stringLiteral94FFD26B9FC865144CCBD5729EA8FAFF93163FB4);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadLockWindow = _stringLiteral05E4ED4BBD99C86DD56D953A9D396662EB0F131F;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeySkadLockWindow), (void*)_stringLiteral05E4ED4BBD99C86DD56D953A9D396662EB0F131F);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsBaseUrl = _stringLiteral62EEE5AB24B108CBF7AD1EA8323A060FA5C4FF46;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsBaseUrl), (void*)_stringLiteral62EEE5AB24B108CBF7AD1EA8323A060FA5C4FF46);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsGdprUrl = _stringLiteralD8A485D101F805D29BFCDD25C667CB04AD5CC888;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsGdprUrl), (void*)_stringLiteralD8A485D101F805D29BFCDD25C667CB04AD5CC888);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsSubscriptionUrl = _stringLiteralEC54F561E7F139CCBA98C2FC655446C34C074D4C;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsSubscriptionUrl), (void*)_stringLiteralEC54F561E7F139CCBA98C2FC655446C34C074D4C);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsExtraPath = _stringLiteral9F85DBEFEA5FADBE3465375963EFAA0318BDEB3E;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsExtraPath), (void*)_stringLiteral9F85DBEFEA5FADBE3465375963EFAA0318BDEB3E);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsBasePath = _stringLiteral5F02F365CDC640D33E644AC0D33DF8A23652EC84;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsBasePath), (void*)_stringLiteral5F02F365CDC640D33E644AC0D33DF8A23652EC84);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsGdprPath = _stringLiteralB3C02481F1EF6B21AC4FFB169F97120EA8E71309;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsGdprPath), (void*)_stringLiteralB3C02481F1EF6B21AC4FFB169F97120EA8E71309);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsDeleteState = _stringLiteralCC3135654FE5454A443D0D19C37529E7EE6B1408;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsDeleteState), (void*)_stringLiteralCC3135654FE5454A443D0D19C37529E7EE6B1408);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsUseTestConnectionOptions = _stringLiteralCCED2B25A49F5AB8A840818C053B996994270607;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsUseTestConnectionOptions), (void*)_stringLiteralCCED2B25A49F5AB8A840818C053B996994270607);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsTimerIntervalInMilliseconds = _stringLiteralF64BAE12AD307231B0FE01E55EB3DE58705EAE36;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsTimerIntervalInMilliseconds), (void*)_stringLiteralF64BAE12AD307231B0FE01E55EB3DE58705EAE36);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsTimerStartInMilliseconds = _stringLiteralCCE5B17A5BD05AD9EF1BD09EF01F0A033B402D86;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsTimerStartInMilliseconds), (void*)_stringLiteralCCE5B17A5BD05AD9EF1BD09EF01F0A033B402D86);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsSessionIntervalInMilliseconds = _stringLiteralF931DEE4A87FE21CBBACC583499FBCF32B68B467;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsSessionIntervalInMilliseconds), (void*)_stringLiteralF931DEE4A87FE21CBBACC583499FBCF32B68B467);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsSubsessionIntervalInMilliseconds = _stringLiteralFC0ADAE748048E8066A24C5A9E285FE94437F54C;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsSubsessionIntervalInMilliseconds), (void*)_stringLiteralFC0ADAE748048E8066A24C5A9E285FE94437F54C);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsTeardown = _stringLiteralD4C9D2736EA3E360FBB7AB6F8774B3D92E886B12;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsTeardown), (void*)_stringLiteralD4C9D2736EA3E360FBB7AB6F8774B3D92E886B12);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsNoBackoffWait = _stringLiteral79FCA40744698D355AA21CA8D1C6D723796755E3;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsNoBackoffWait), (void*)_stringLiteral79FCA40744698D355AA21CA8D1C6D723796755E3);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsiAdFrameworkEnabled = _stringLiteral7D046F7A5E043071C26805C1E921D468CAB706D4;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsiAdFrameworkEnabled), (void*)_stringLiteral7D046F7A5E043071C26805C1E921D468CAB706D4);
		((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsAdServicesFrameworkEnabled = _stringLiteral09F6BF5807F21976DC5A8B817678D0F3CA09B367;
		Il2CppCodeGenWriteBarrier((void**)(&((AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_StaticFields*)il2cpp_codegen_static_fields_for(AdjustUtils_t6E7EE6AEF4EAC64EA2764254CA559FA0012A256A_il2cpp_TypeInfo_var))->___KeyTestOptionsAdServicesFrameworkEnabled), (void*)_stringLiteral09F6BF5807F21976DC5A8B817678D0F3CA09B367);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___hasValue;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_m6B76D139692C43B2AF7C695FAB044B16ACFAF355_gshared_inline (Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___hasValue;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_gshared_inline (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___hasValue;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mCF2FD8B3055FA87FC9C504F2122B3B0FAEDE3EC9_gshared_inline (Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___hasValue;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB4991C0F4C2664AB3CB2584DEECF5BCE6AB7757D_gshared_inline (Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = __this->___hasValue;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____size;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) 
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = __this->____version;
		__this->____version = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_1 = __this->____items;
		V_0 = L_1;
		int32_t L_2 = __this->____size;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6 = V_0;
		int32_t L_7 = V_1;
		RuntimeObject* L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		return;
	}

IL_0034:
	{
		RuntimeObject* L_9 = ___0_item;
		List_1_AddWithResize_m79A9BF770BEF9C06BE40D5401E55E375F2726CC4(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 14));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->____current;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 Enumerator_get_Current_mE3475384B761E1C7971D3639BD09117FE8363422_gshared_inline (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) 
{
	{
		KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 L_0 = __this->____current;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___value;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = __this->___key;
		return L_0;
	}
}
