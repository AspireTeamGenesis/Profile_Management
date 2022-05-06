using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PMS.API
{
    public class UserValidation
    {
        public bool userValidate(User user){
            if(!string.IsNullOrEmpty(user.Name))
                throw new ValidationException($"UserName not be null{user.Name}");
            if(!Regex.IsMatch(user.Name, @"^(?!.*([ ])\1)(?!.*([A-Za-z])\2{2})\w[a-zA-Z\s]*$"))
                throw new ValidationException($"Name must not contain any special character or numbers{user.Name}");
            if(user.Name.Length<4)
                throw new ValidationException($"Length cannot less than 4-{user.Name}");
            if(user.Name.Length>30)
                throw new ValidationException($"Length cannot greater than 30{-user.Name}");
            if(!string.IsNullOrEmpty(user.Email))
                throw new ValidationException($"Email not be null{user.Email}");
            if(!Regex.IsMatch(user.Email,@"^([0-9a-zA-Z.]){3,}@[a-zA-z]{3,}(.[a-zA-Z]{2,}[a-zA-Z]*){0,}$"))
                throw new ValidationException($"Enter valid Email address{user.Email}");
            if(!string.IsNullOrEmpty(user.UserName))
                throw new ValidationException($"UserName not be null{user.UserName}");
            if(!Regex.IsMatch(user.UserName, @"^[A-z][A-z|\.|\s]+$"))
                throw new ValidationException($"Enter valid UserName{user.UserName}");
            if(!string.IsNullOrEmpty(user.Password))
                throw new validationException($"Password not be null{user.Password}");
            if(!Regex.IsMatch(user.Password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$"))
                throw new validationException($"Enter a valid Password. Password must contain Minimum eight characters, at least one letter, one number and one special character{user.Password}");
            if(!string.IsNullOrEmpty(user.Gender))
                throw new validationException($"Gender not be null{user.Gender}");
            if(user.MobileNo==0)
                throw new validationException($"MobileNo not be null{user.MobileNo}");
            if(!string.IsNullOrEmpty(user.Organization))
                throw new validationException($"Organization not be null{user.Organization}");
            if(!string.IsNullOrEmpty(user.Designation))
                throw new validationException($"Designation not be null{user.Designation}");
            if(!string.IsNullOrEmpty(user.Reporting_Person))
                throw new validationException($"Reporting_Person not be null{user.Reporting_Person}");

        }
    }
}