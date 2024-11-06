cd ../build
bash build-backend.sh
bash build-migrator.sh
bash build-frontend.sh
cd ../deploy
docker-compose -f docker-compose.dev.yml up -d