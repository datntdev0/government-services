# run from the build directory
cd ../../aspnet-core
docker build -t datntdev/government-services/migrator -f src/Government.Services.Migrator/Dockerfile .