using System;
using CoreLocation;
using Foundation;
using Security;
using UIKit;

namespace AmplitudeSdk
{


	partial interface Constants
	{
		// extern NSString *const kAMPLibrary;
		[Field ("kAMPLibrary")]
		NSString kAMPLibrary { get; }

		// extern NSString *const kAMPPlatform;
		[Field ("kAMPPlatform")]
		NSString kAMPPlatform { get; }

		// extern NSString *const kAMPVersion;
		[Field ("kAMPVersion")]
		NSString kAMPVersion { get; }

		// extern NSString *const kAMPEventLogUrl;
		[Field ("kAMPEventLogUrl")]
		NSString kAMPEventLogUrl { get; }

		// extern const int kAMPApiVersion;
		[Field ("kAMPApiVersion")]
		int kAMPApiVersion { get; }

		// extern const int kAMPEventUploadThreshold;
		[Field ("kAMPEventUploadThreshold")]
		int kAMPEventUploadThreshold { get; }

		// extern const int kAMPEventUploadMaxBatchSize;
		[Field ("kAMPEventUploadMaxBatchSize")]
		int kAMPEventUploadMaxBatchSize { get; }

		// extern const int kAMPEventMaxCount;
		[Field ("kAMPEventMaxCount")]
		int kAMPEventMaxCount { get; }

		// extern const int kAMPEventRemoveBatchSize;
		[Field ("kAMPEventRemoveBatchSize")]
		int kAMPEventRemoveBatchSize { get; }

		// extern const int kAMPEventUploadPeriodSeconds;
		[Field ("kAMPEventUploadPeriodSeconds")]
		int kAMPEventUploadPeriodSeconds { get; }

		// extern const long kAMPMinTimeBetweenSessionsMillis;
		[Field ("kAMPMinTimeBetweenSessionsMillis")]
		nint kAMPMinTimeBetweenSessionsMillis { get; }

		// extern const long kAMPSessionTimeoutMillis;
		[Field ("kAMPSessionTimeoutMillis")]
		nint kAMPSessionTimeoutMillis { get; }
	}

	// @interface AMPDeviceInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AMPDeviceInfo
	{
		// @property (readonly) NSString * appVersion;
		[Export ("appVersion")]
		string AppVersion { get; }

		// @property (readonly) NSString * osName;
		[Export ("osName")]
		string OsName { get; }

		// @property (readonly) NSString * osVersion;
		[Export ("osVersion")]
		string OsVersion { get; }

		// @property (readonly) NSString * manufacturer;
		[Export ("manufacturer")]
		string Manufacturer { get; }

		// @property (readonly) NSString * model;
		[Export ("model")]
		string Model { get; }

		// @property (readonly) NSString * carrier;
		[Export ("carrier")]
		string Carrier { get; }

		// @property (readonly) NSString * country;
		[Export ("country")]
		string Country { get; }

		// @property (readonly) NSString * language;
		[Export ("language")]
		string Language { get; }

		// @property (readonly) NSString * advertiserID;
		[Export ("advertiserID")]
		string AdvertiserID { get; }

		// @property (readonly) NSString * vendorID;
		[Export ("vendorID")]
		string VendorID { get; }

		// -(NSString *)generateUUID;
		[Export ("generateUUID")]
		string GenerateUUID { get; }
	}

	// @interface AMPLocationManagerDelegate : NSObject <CLLocationManagerDelegate>
	[BaseType (typeof(NSObject))]
	interface AMPLocationManagerDelegate : ICLLocationManagerDelegate
	{
		// -(void)locationManager:(CLLocationManager *)manager didFailWithError:(NSError *)error;
		[Export ("locationManager:didFailWithError:")]
		void LocationManager (CLLocationManager manager, NSError error);

		// -(void)locationManager:(CLLocationManager *)manager didUpdateToLocation:(CLLocation *)newLocation fromLocation:(CLLocation *)oldLocation;
		[Export ("locationManager:didUpdateToLocation:fromLocation:")]
		void LocationManager (CLLocationManager manager, CLLocation newLocation, CLLocation oldLocation);

		// -(void)locationManager:(CLLocationManager *)manager didChangeAuthorizationStatus:(CLAuthorizationStatus)status;
		[Export ("locationManager:didChangeAuthorizationStatus:")]
		void LocationManager (CLLocationManager manager, CLAuthorizationStatus status);
	}
		

	// @interface Amplitude : NSObject
	[BaseType (typeof(NSObject))]
	public interface Amplitude
	{
		// @property (readonly, nonatomic) NSString * apiKey;
		[Export ("apiKey")]
		string ApiKey { get; }

		// @property (readonly, nonatomic) NSString * userId;
		[Export ("userId")]
		string UserId { get; }

		// @property (assign, nonatomic) BOOL optOut;
		[Export ("optOut")]
		bool OptOut { get; set; }

		// +(Amplitude *)instance;
		[Static]
		[Export ("instance")]
		Amplitude Instance { get; }

		// -(void)initializeApiKey:(NSString *)apiKey;
		[Export ("initializeApiKey:")]
		void InitializeApiKey (string apiKey);

		// -(void)initializeApiKey:(NSString *)apiKey userId:(NSString *)userId;
		[Export ("initializeApiKey:userId:")]
		void InitializeApiKey (string apiKey, string userId);

		// -(void)logEvent:(NSString *)eventType;
		[Export ("logEvent:")]
		void LogEvent (string eventType);

		// -(void)logEvent:(NSString *)eventType withEventProperties:(NSDictionary *)eventProperties;
		[Export ("logEvent:withEventProperties:")]
		void LogEvent (string eventType, NSDictionary eventProperties);

		// -(void)logRevenue:(NSNumber *)amount;
		[Export ("logRevenue:")]
		void LogRevenue (NSNumber amount);

		// -(void)logRevenue:(NSString *)productIdentifier quantity:(NSInteger)quantity price:(NSNumber *)price;
		[Export ("logRevenue:quantity:price:")]
		void LogRevenue (string productIdentifier, nint quantity, NSNumber price);

		// -(void)logRevenue:(NSString *)productIdentifier quantity:(NSInteger)quantity price:(NSNumber *)price receipt:(NSData *)receipt;
		[Export ("logRevenue:quantity:price:receipt:")]
		void LogRevenue (string productIdentifier, nint quantity, NSNumber price, NSData receipt);

		// -(void)uploadEvents;
		[Export ("uploadEvents")]
		void UploadEvents ();

		// -(void)setUserProperties:(NSDictionary *)userProperties;
		[Export ("setUserProperties:")]
		void SetUserProperties (NSDictionary userProperties);

		// -(void)setUserProperties:(NSDictionary *)userProperties replace:(BOOL)replace;
		[Export ("setUserProperties:replace:")]
		void SetUserProperties (NSDictionary userProperties, bool replace);

		// -(void)setUserId:(NSString *)userId;
		[Export ("setUserId:")]
		void SetUserId (string userId);

		// -(void)enableLocationListening;
		[Export ("enableLocationListening")]
		void EnableLocationListening ();

		// -(void)disableLocationListening;
		[Export ("disableLocationListening")]
		void DisableLocationListening ();

		// -(void)useAdvertisingIdForDeviceId;
		[Export ("useAdvertisingIdForDeviceId")]
		void UseAdvertisingIdForDeviceId ();

		// -(void)printEventsCount;
		[Export ("printEventsCount")]
		void PrintEventsCount ();

		// -(NSString *)getDeviceId;
		[Export ("getDeviceId")]
		string DeviceId { get; }

	}
}