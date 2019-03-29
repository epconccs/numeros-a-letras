coverlet nal.Test/bin/Debug/netcoreapp2.1/nal.Test.dll --target "dotnet" --targetargs "test nal.Test --no-build" --exclude "[xunit.*]*"

dotnet test nal.Test/nal.Test.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:Exclude="[xunit.*]*" /p:CoverletOutput=../lcov.info