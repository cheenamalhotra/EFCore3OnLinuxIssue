**STR**

1. Create Azure SQL database instance
2. Put database connection string into ```Storage:Database:ConnectionString``` of ```appsetttings.config```
3. Build docker image ```docker build  -f ./src/DemoProject/Dockerfile .```
4. Run docker image ```docker run HASH```