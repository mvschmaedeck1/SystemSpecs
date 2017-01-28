using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum ConfigManagerErrorCode
    {
        [Description("Device is working properly.")]
        Properly,

        [Description("Device is not configured correctly.")]
        BadConfig,

        [Description("Windows cannot load the driver for this device.")]
        BadDriver_1,

        [Description("Driver for this device might be corrupted, or the system may be low on memory or other resources.")]
        BadDriver_2,

        [Description("Device is not working properly. One of its drivers or the registry might be corrupted.")]
        BadDriver_3,

        [Description("Driver for the device requires a resource that Windows cannot manage.")]
        BadDriver_4,

        [Description("Boot configuration for the device conflicts with other devices.")]
        BadBoot,

        [Description("Cannot filter.")]
        BadFilter,

        [Description("Driver loader for the device is missing.")]
        BadDriverLoader,

        [Description("Device is not working properly. The controlling firmware is incorrectly reporting the resources for the device.")]
        BadControllingFirmware,

        [Description("Device cannot start.")]
        BadStart,

        [Description("Device failed.")]
        Failed,

        [Description("Device cannot find enough free resources to use.")]
        BadResources_1,

        [Description("Windows cannot verify this device's resources.")]
        BadResources_2,

        [Description("Device cannot work properly until the computer is restarted.")]
        RestartNeeded,

        [Description("Device is not working properly due to a possible re-enumeration problem.")]
        ReenumerationProblem,

        [Description("Windows cannot identify all of the resources that the device uses.")]
        BadResources_3,

        [Description("Device is requesting an unknown resource type.")]
        UnknowResource,

        [Description("Device drivers must be reinstalled.")]
        DriverReinstallNeeded,

        [Description("Failure using the VxD loader.")]
        FailureVxDLoader,

        [Description("Registry might be corrupted.")]
        CorruptedRegistry,

        [Description("System failure. If changing the device driver is ineffective, see the hardware documentation. Windows is removing the device.")]
        SystemFailure_1,

        [Description("Device is disabled.")]
        Disabled,

        [Description("System failure. If changing the device driver is ineffective, see the hardware documentation.")]
        SystemFailure_2,

        [Description("Device is not present, not working properly, or does not have all of its drivers installed.")]
        GenericError,

        [Description("Windows is still setting up the device.")]
        SettingUp_1,

        [Description("Windows is still setting up the device.")]
        SettingUp_2,

        [Description("Device does not have valid log configuration.")]
        BadLogConfig,

        [Description("Device drivers are not installed.")]
        UninstalledDrivers,

        [Description("Device is disabled. The device firmware did not provide the required resources.")]
        BadFirmware,

        [Description("Device is using an IRQ resource that another device is using.")]
        UsedIrqResource,

        [Description("Device is not working properly. Windows cannot load the required device drivers.")]
        CantLoadDriver
    }
}