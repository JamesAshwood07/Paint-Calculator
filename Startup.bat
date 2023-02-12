cd Source\Paint-Calculator
docker-compose up -d
cd ..
timeout 5
explorer "https://localhost:8082"