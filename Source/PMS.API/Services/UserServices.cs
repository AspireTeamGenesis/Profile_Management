using System;
using System.ComponentModel.DataAnnotations;
using PMS_API.API.UtilityFunctions;

namespace PMS_API{
   

    public class UserServices : IUserServices
    {
        private UserData userData;

        private ILogger<UserServices> _logger;
      
        public UserServices(ILogger<UserServices> logger){
            _logger=logger;
            userData=UserDataFactory.GetUserObject(logger);
        }
        private UserValidation _validation=UserDataFactory.GetValidationObject();
        public object GetallUsers(int profilestatusId)
        {
            try{
                // IEnumerable<User> userDetails = new List<User>();
             
                return (from  user in userData.GetallForCard(profilestatusId) where user.IsActive==true select user).Select(
                    user => new{
                        UserId=user.UserId,
                        Name=user.Name,
                        UserDesignation=user.designation.DesignationName,
                        ReportingPerson=user.ReportingPersonUsername,
                        UserProfileStatus=user.profile.profilestatus.ProfileStatusName,
                        UserProfileImage=user.personalDetails.Image,
                        UserProfileId=user.profile.ProfileId
                    }
                );
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"UserServices:GetAll()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public Object GetSpecificUserDetails()
        {
            try
            {
                return (from user in userData.GetallUsers() select user).ToList()
                .Select(var => new
                {
                    Name = var.Name,
                    UserId=var.UserId,
                    Designation = var.designation.DesignationName,
                    ReportingPerson = var.ReportingPersonUsername
                }
                );
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"User Service : GetSpecificUserDetails() : {exception.Message} : {exception.StackTrace}");
                throw exception;
            }
        }
        public object GetUser(int id)
        {
            if(id<=0)
                throw new ArgumentNullException($"ID is not provided{id}");
            try
            {
                var getuser= userData.GetUser(id); 
                if(getuser.IsActive==true){
                return new {
                    userid=getuser.UserId,
                    name =getuser.Name,
                    email=getuser.Email,
                    username=getuser.UserName,
                    password=getuser.Password,
                    genderId=getuser.GenderId,
                    gender=getuser.gender.GenderName,
                    CountryCodeId=getuser.CountryCodeId,
                    countryCode=getuser.countrycode.CountryCodeName,
                    mobilenumber=getuser.MobileNumber,
                    designationId=getuser.DesignationId,
                    designation=getuser.designation.DesignationName,
                    reportingpersonUsername=getuser.ReportingPersonUsername,
                    organisationId=getuser.OrganisationId,
                    organisation=getuser.organisation.OrganisationName

                };}
                else{
                    throw new ValidationException("User not found");
                }
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetUser()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool AddUser(User item,int userId)

        {
            if(item==null)
                throw new ArgumentNullException($"UserServices:Add()-user values should not be null{item}");
             _validation.userValidate(item);
            try
            {
                item.CreatedBy=userId;
                item.CreatedOn=DateTime.Now;
                return userData.AddUser(item)?true:false;              //Ternary operator
                
            }
            catch(ValidationException exception){
                _logger.LogInformation($"UserServices:Add()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
            catch(ArgumentNullException exception){
                _logger.LogInformation($"UserServices:Add()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Add()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        public bool Disable(int id)
        {
            if(id<=0)
                throw new ArgumentNullException($"ID is not provided{id}");

            
            try
            {

                return userData.Disable(id)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }
        public bool UpdateUser(User item)
        {
            
            if(item==null)throw new ArgumentNullException($" UserServices:Update()-user values not be null{item}");
            _validation.userValidate(item);
            try{
                
               item.UpdatedBy=item.UserId;
                item.UpdatedOn=DateTime.Now;
                return userData.UpdateUser(item)?true:false;
                
            }
            
            catch(Exception exception){
                 _logger.LogInformation($"UserServices:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        public bool ChangePassword(string OldPassword,string NewPassword,string ConfirmPassword,int currentUser)

        {

            PasswordValidation.IsValidPassword(NewPassword,ConfirmPassword);




            try
            {
                if(NewPassword != ConfirmPassword)
                    throw new ValidationException($"The confirm password should be the same as new password : {ConfirmPassword}");
                else{
                    return userData.EditPassword(OldPassword,NewPassword,ConfirmPassword,currentUser) ? true : false;
                }

            }

            catch (ArgumentException exception)

            {

                _logger.LogInformation($"User service : EditPassword(string OldPassword,string NewPassword,string ConfirmPassword) : {exception.Message}");

                return false;

            }

            catch (ValidationException passwordNotValid)

            {

                _logger.LogInformation($"User service :EditPassword(string OldPassword,string NewPassword,string ConfirmPassword): {passwordNotValid.Message}");

                throw passwordNotValid;

            }

            catch (Exception exception)

            {

                _logger.LogInformation($"User service :EditPassword(string OldPassword,string NewPassword,string ConfirmPassword):{exception.Message}");

                return false;

            }

        }
        public bool Save()
        {
            return userData.save();
        }
    }
}