# Sitecore and MVC A-to-Z

This is the project that I use for my Sitecore and MVC A-to-Z presentation demo.

## Usage

1. Install a new instance of Sitecore 8.2 Update-2.
2. [Configure the Sitecore NuGet feed in Visual Studio](https://doc.sitecore.net/sitecore_experience_platform/developing/developing_with_sitecore/sitecore_public_nuget_packages_faq).
3. Update the `publishUrl` in the [publish profile](MvcAtoZ\Properties\PublishProfiles\MvcAtoZ.pubxml) to point to your Sitecore installation.
4. Update the `physicalRootPath` in [MvcAtoZ.SerializationFolder.config](MvcAtoZ\App_Config\Include\z.MvcAtoZ\MvcAtoZ.SerializationFolder.config) to point to the correct path on your disk.
5. Publish the solution.
6. Perform a full site publish.
