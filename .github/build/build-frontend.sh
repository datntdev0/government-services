# run from the build directory
cd ../../angular
docker build -t datntdev/government-services/frontend -f Dockerfile --build-arg BUILD_ENV=dev .