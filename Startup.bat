cd Source\Paint-Calculator & :: Enters the correct folder
docker-compose up -d & :: Runs the docker-compose file
cd .. & :: Returns back to the original section
timeout 5 & :: Waits 5 seconds
explorer "https://localhost:8082" & :: Opens the website