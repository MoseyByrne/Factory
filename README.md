# Factory

#### By Mo Byrne

#### An application to keep track of a factory's engineers and machines.

## Technologies Used

* C#
* Razor
* HTML
* CSS
* Bootstrap
* MySQL
* Entity

## Description

A webpage for the owner of an imaginary factory to add engineers when they are hired, then add what machines they are licensed to work on. New machines can also be added and have engineers assigned to them.  

## Setup/Installation Requirements

* Open console application, and run the command


    ``git clone https://github.com/MoseyByrne/Factory``

* Then run 

    ``cd Factory``

* You should now have a folder `Factory` with the following structure.
    <pre>Factory
    └── Factory
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        └── Startup.cs</pre>

* Add a file named appsettings.json in the following location 

    <pre>Factory
    └── Factory
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        ├── Startup.cs
        └── <strong>appsettings.json</strong></pre>

* Copy and paste below JSON text in appsettings.json.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=mo_byrne;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]"
  }
}
```

* Replace [YOUR-USERNAME-HERE] with your MySQL username.

* Replace [YOUR-PASSWORD-HERE] with your MySQL password.


* To navigate to the following directory in the console run ``cd Factory``
  
    <pre>Factory
    └── <strong>Factory</strong>
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        ├── Startup.cs
        └── appsettings.json</pre>

Run the following command in the console

  ``dotnet build``

Then run this command in the console

  ``dotnet run``


## Known Bugs

* _No known issues_

## License


Copyright (c) 08/05/2022 Mo Byrne