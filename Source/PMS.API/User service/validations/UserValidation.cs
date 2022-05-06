// using System.ComponentModel.DataAnnotations;
// using System.Text.RegularExpressions;

// namespace PMS.API
// {
//     public class UserValidation
//     {
//         public bool userValidate(User user){
//             if(!string.IsNullOrEmpty(user.Name))
//                 throw new ValidationException($"UserName not be null{user.Name}");
//             if(!Regex.IsMatch(user.Name, @"^(?!.*([ ])\1)(?!.*([A-Za-z])\2{2})\w[a-zA-Z\s]*$"))
//                 throw new ValidationException($"Name must not contain any special character or numbers{user.Name}");
//             if(user.Name.Length<4)
//                 throw new ValidationException($"Length cannot less than 4")

//         }
//     }
// }