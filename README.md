# How to run
1. Run app: "docker-compose build ; docker-compose up"
2. Create user in /Account/Register
3. Get rights for your user /Account/Edit?name=userName (for the changes to take effect, you need to log out and log in again)
4. Enjoy!

# How to make migrations
1. Go to \Matbox.DAL\Models
2. dotnet ef --startup-project ..\Matbox.WEB\ database update --context UsersDbContext
3. dotnet ef --startup-project ..\Matbox.WEB\ database update --context MaterialsDbContext

# WebAPI methods
Swagger available on localhost:[port]/
1. getAllMaterials - will return all materials that are stored in the application.
2. getInfoAboutMaterial - will return information about all versions of the material (you must pass materialName in the request body)
3. getInfoWithFilters - will return information about all versions of materials of a certain category and size (you must pass them in the request body)
4. getActualMaterial - will return the latest version of the material for download (you must pass the materialName in the request body)
5. getSpecificMaterial - will return a specific version of the material for download (you must pass the name and version in the request body)
6. addNewMaterial - adds new material to the app (in the request body, you must pass the file and it's category. Possible categories of material: Презентация, Приложение, Другое)
7. addNewVersionOfMaterial - adds new version of material to the app (in the request body, you must pass the file)
8. changeCategoryOfMaterial - changes the category of the material in all versions (in the request body, you must pass the materialName and newCategory)
