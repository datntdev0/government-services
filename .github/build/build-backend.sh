# run from the build directory
cd ../../aspnet-core
docker build -t datntdev/government-services/backend -f src/Government.Services.Web.Host/Dockerfile .