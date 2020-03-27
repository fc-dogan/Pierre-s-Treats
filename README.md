# _Pierre's Sweet and Savory Treats_

####  MVC web application to Pierre's market his sweet and savory treats  , March 27 2020_

#### By _**Fatma C. Dogan**_

## Description

A web application with user authentication and a many-to-many relationship. The application allows users to log in and logout. All users can see all list of treats and flavors, but only logged-in users can add, edit, and delete the treats or flavors.


## Project Specifications

| Behavior | Input | Output |
|---|:---|:---|
|When the user runs the application, they receive a welcome message along with the links for a list of flavors/treats, and for register/log in. | Home page | Welcome to Pierre's Sweet and Savory Treats!<br> ``See all flavors``<br>``See all treats`` <br>``Account``|
|When the user clicks "see all flavor", receives a list of flavors | ``see all flavors`` | Flavors : <br> * savory <br>  ``add a new flavor  `` |
|When a logged in user clicks on "add a new flavor ", they receive a form to add a new flavor| ``add a new flavor  `` | Add a new flavor <br> Name : |
|When a User Adds a new flavor they are directed to the flavors list page  | Name: Sweet | Flavors :<br> * savory <br> * sweet <br>  ``add a new flavor  `` |
|When the user clicks a specific flavor name they receive all the treats that belong to that flavor| ``sweet`` |  Flavors : <br> * cheesecake <br> * chocolate croissant |
|When the user clicks "see all treats" at the home page, receives a list of treats | ``see all treats `` | Treats: <br> * cheesecake <br> ``add a new treat``  |
|When the user clicks a specific treat name they receive all the flavors that belong to that treat | ``cheesecake`` | Treat: cheesecake <br> flavors of this treat : <br> *sweet |
|Logged in users receive `delete treat` and `edit treat` links || 
|When the logged in user clicks on "edit treat" link, they are directed to the treat edit page | ``edit`` | Edit :cheesecake ``save`` |
|After the user saves the changes, they are directed to the Treat list page | `save` | "Treat list"|
|When the user clicks on "delete" link, they are directed to the treat delete page | ``delete``|  "Are you sure you want to delete this?" <br> Name: Cheesecake <br> button:`delete`|
|After the user delete the treat, they are directed to the treat list page | ``delete`` | "Treats"|
|The logged in user receives `add a new treat` link on Treat list page |
|When the user clicks on `add a new treat` link, they are directed to the treat create form page |`add a new treat`  |"add an new treat" <br> Name: <br> Select flavor:  <br> `"add new treat`| 
|After the user create a new treat and submit the form, they are directed to the treat list page | Name : " chocolate croissants"<br> Flavor: "sweet"  | "treats list"|
|||
 


## Setup/Installation Requirements

### Install .NET Core

* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

### Install MySQL Community Server and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [MySQL Community Server page](https://dev.mysql.com/downloads/file/?id=484914). 
* Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
      * use legacy password encryption
      * set password 
      * click finish

* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here}``.  
  You can exit the mysql program by entering exit.

_Download MySQL Workbench DMG file [ MySQL Workbench page](https://dev.mysql.com/downloads/file/?id=484391). 
* Install MySQL Workbench to Applications folder. 
* Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [MySQL Web Installer ](https://dev.mysql.com/downloads/file/?id=484919) 
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: 
    * MySQL Server (Will be under MySQL Servers) 
    * MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation 
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here}``. It's working correctly if you gain access to the MySQL command line. 
  You can exit the mysql program by entering `exit`


### Download this repository

_Download Manually:_

* Navigate to https://github.com/fc-dogan/Pierre-s-Treats.git
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Pierre-s-Treats".

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
  ```
  cd desktop
  ```
* Clone the file from GitHub with HTTPS
  ```
  git clone https://github.com/fc-dogan/Pierre-s-Treats.git 
  ```
* Open file in your preferred text editor
  ```
  cd Pierre-s-Treats
    ```
* Change directories into the project directory
  ``` 
  cd Pierre-s-Treats/PierresTreats
   ```

* Restore all dependencies
  ```
   dotnet restore
   ```
* Build the project and dependencies
   ```
   dotnet build
   ```

## Create the Database

* Build the database
  ```
  dotnet ef migrations add Initial
  dotnet ef database update
  ```

_To run this application:_


* Run the program
  ``` 
  dotnet run
  ```
   Note: To exit, simply press ```Ctrl + C```
* Open the local hosted server
  ```
   http://localhost:5000 
   ```



## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* .Net Core 2.2
* ASP.NET Core MVC
* MySQL, MySQL Workbench
* Entity Framework Core
* LINQ
* VS Code
* CSS
* Bootstrap

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Fatma C. Dogan_**