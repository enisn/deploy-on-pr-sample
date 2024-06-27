param (
    [string]$tag = "latest",
    [string]$registry = "registry-lo8ocsg.enisn-projects.io",
    [switch]$push = $false
 )

docker build -t $registry/enisn/deployonprsample:$tag -f .\DeployOnPrSample\Dockerfile --platform linux/amd64 -t alyxw/alace-cs:amd64 .

if ($push) {
    pwsh push.ps1 $tag $registry
}