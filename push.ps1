param (
    [string]$tag = "latest",
    [string]$registry = "registry-lo8ocsg.enisn-projects.io"
 )

docker push $registry/enisn/deployonprsample:$tag