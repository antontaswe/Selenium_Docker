# Selenium grid for automated testing

To get the environment running in Docker:
1. Clone this repo
2. CD to local folder of cloned repo
3. Execute docker-compose up -d
4. Verify status of grid at http://localhost:4444/grid/console
5. Use VNC client to debug tests on nodes, by connecting to localhost:port (see ports below), password = secret

Hub
- Listening on port 4444 (external and internal)

Firefox-node
- Listening on port 4445 (internal port 5900)

Chrome-node
- Listening on port 4446 (internal port 5900)