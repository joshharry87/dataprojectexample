using JWDIACONTRACTS.DTO.Auth;
using JWDIADATA.Data.Entities;




namespace JWDIACONTRACTS.Mappings.Auth;


public class UserMappings
{

    public UserMappings(){
        
    }


    public static UserDataModel NewUserConverter(NewUser a)
    {
        var b = new JWDIADATA.Data.Entities.UserDataModel(){
            Username = a.Username,
            Password = a.Password,
            RequireUniqueEmail = a.RequireUniqueEmail
        };
   


        return b;
    }

    public static UserDTO UserConverter(UserDataModel a){
        var b = new UserDTO(){
            Username = a.Username,
                Password = a.Password,
                RequireUniqueEmail = a.RequireUniqueEmail,
                Id = a.Id,
        };


        return b;
    }


    
}
