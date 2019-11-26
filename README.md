**STR**

1. Create Azure SQL database instance
2. Put database connection string into ```Storage:Database:ConnectionString``` of ```appsetttings.config```
3. Build docker image ```docker build  -f ./src/EFCore3Demo/Dockerfile .``` for EF Core 3 or ```docker build  -f ./src/EFCore22Demo/Dockerfile .``` for EF Core 2.2.6 with SqlClient 4.7.0 
4. Run docker image ```docker run HASH```
