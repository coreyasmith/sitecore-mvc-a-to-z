# Sitecore and MVC A-to-Z

This is the project that I use for my Sitecore and MVC A-to-Z presentation demo.

## Usage

1. Install a new instance of Sitecore 9.0 Update-2.
2. Create a self-signed certificate for your Sitecore installation and add the certificate to the site in IIS. [This script will help][1].
2. Update the `publishUrl` in the [publish profile][2] to point to your Sitecore installation.
3. Update the `physicalRootPath` in [MvcAtoZ.SerializationFolder.config][3] to point to the correct path on your disk.
4. Publish the solution.
5. Perform a full site publish.

[1]: https://gist.github.com/coreyasmith/693126c6949af3a63157de378657f23c
[2]: MvcAtoZ/Properties/PublishProfiles/MvcAtoZ.pubxml
[3]: MvcAtoZ/App_Config/Include/z.MvcAtoZ/MvcAtoZ.SerializationFolder.config
