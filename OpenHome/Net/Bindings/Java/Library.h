/* DO NOT EDIT THIS FILE - it is machine generated */
#include <jni.h>
/* Header for class org_openhome_net_core_Library */

#ifndef _Included_org_openhome_net_core_Library
#define _Included_org_openhome_net_core_Library
#ifdef __cplusplus
extern "C" {
#endif
/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryInitialise
 * Signature: (J)J
 */
JNIEXPORT jlong JNICALL Java_org_openhome_net_core_Library_OhNetLibraryInitialise
  (JNIEnv *, jclass, jlong);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryInitialiseMinimal
 * Signature: (J)J
 */
JNIEXPORT jlong JNICALL Java_org_openhome_net_core_Library_OhNetLibraryInitialiseMinimal
  (JNIEnv *, jclass, jlong);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryStartCp
 * Signature: (I)I
 */
JNIEXPORT jint JNICALL Java_org_openhome_net_core_Library_OhNetLibraryStartCp
  (JNIEnv *, jclass, jint);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryStartDv
 * Signature: ()I
 */
JNIEXPORT jint JNICALL Java_org_openhome_net_core_Library_OhNetLibraryStartDv
  (JNIEnv *, jclass);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryStartCombined
 * Signature: (I)I
 */
JNIEXPORT jint JNICALL Java_org_openhome_net_core_Library_OhNetLibraryStartCombined
  (JNIEnv *, jclass, jint);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryClose
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_openhome_net_core_Library_OhNetLibraryClose
  (JNIEnv *, jclass);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetSetCurrentSubnet
 * Signature: (J)V
 */
JNIEXPORT void JNICALL Java_org_openhome_net_core_Library_OhNetSetCurrentSubnet
  (JNIEnv *, jclass, jlong);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetCurrentSubnetAdapter
 * Signature: ()J
 */
JNIEXPORT jlong JNICALL Java_org_openhome_net_core_Library_OhNetCurrentSubnetAdapter
  (JNIEnv *, jclass);

/*
* Class:     org_openhome_net_core_Library
* Method:    OhNetAbortProcess
* Signature: ()V
*/
JNIEXPORT void JNICALL Java_org_openhome_net_core_Library_OhNetRefreshNetworkAdapterList
(JNIEnv *, jclass);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryNotifySuspended
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_openhome_net_core_Library_OhNetLibraryNotifySuspended
  (JNIEnv *, jclass);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetLibraryNotifyResumed
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_openhome_net_core_Library_OhNetLibraryNotifyResumed
  (JNIEnv *, jclass);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetDebugSetLevel
 * Signature: (I)V
 */
JNIEXPORT void JNICALL Java_org_openhome_net_core_Library_OhNetDebugSetLevel
  (JNIEnv *, jclass, jint);

/*
 * Class:     org_openhome_net_core_Library
 * Method:    OhNetAbortProcess
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_openhome_net_core_Library_OhNetAbortProcess
  (JNIEnv *, jclass);

#ifdef __cplusplus
}
#endif
#endif
