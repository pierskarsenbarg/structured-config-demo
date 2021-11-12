# Example of how to use config secrets in resources without using Apply

This example is how to use secrets in structured config as inputs for resources.

I've used resource groups because they're the simplest resource to deploy here.

## Deployment

_Pre-Requisites_: You need the Azure CLI, the Pulumi CLI and .NET Core installed (any version over 3.1).

### Steps

1. Clone this repo: `git clone git@github.com:pierskarsenbarg/structured-config-demo.git`
1. Change to the folder: `cd structured-config-demo`
1. Create a stack: `pulumi stack init dev`
1. Set the Azure Region to deploy this to: `pulumi config set azure-native:region {region}` (i.e. `pulumi config set azure-native:region uksouth`)
1. Add an encrypted resource group name: `pulumi config set --path 'data.resourceGroupName[0]' resourceGroupname0 --secret`
1. Add as many more as you like following the above convention.
1. Preview the deployment: `pulumi preview` - You'll see the new resource groups in the preview because we're not using `Apply()` here.
1. Either deploy (`pulumi up` followe by a destroy `pulumi destroy`) or delete the stack: `pulumi stack rm dev`.
