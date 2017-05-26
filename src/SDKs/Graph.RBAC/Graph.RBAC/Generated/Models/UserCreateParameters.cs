// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Graph;
    using Microsoft.Azure.Graph.RBAC;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request parameters for creating a new work or school account user.
    /// </summary>
    public partial class UserCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the UserCreateParameters class.
        /// </summary>
        public UserCreateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserCreateParameters class.
        /// </summary>
        /// <param name="accountEnabled">Whether the account is
        /// enabled.</param>
        /// <param name="displayName">The display name of the user.</param>
        /// <param name="passwordProfile">Password Profile</param>
        /// <param name="userPrincipalName">The user principal name
        /// (someuser@contoso.com). It must contain one of the verified domains
        /// for the tenant.</param>
        /// <param name="mailNickname">The mail alias for the user.</param>
        /// <param name="immutableId">This must be specified if you are using a
        /// federated domain for the user's userPrincipalName (UPN) property
        /// when creating a new user account. It is used to associate an
        /// on-premises Active Directory user account with their Azure AD user
        /// object.</param>
        public UserCreateParameters(bool accountEnabled, string displayName, PasswordProfile passwordProfile, string userPrincipalName, string mailNickname, string immutableId = default(string))
        {
            AccountEnabled = accountEnabled;
            DisplayName = displayName;
            PasswordProfile = passwordProfile;
            UserPrincipalName = userPrincipalName;
            MailNickname = mailNickname;
            ImmutableId = immutableId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the account is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "accountEnabled")]
        public bool AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets password Profile
        /// </summary>
        [JsonProperty(PropertyName = "passwordProfile")]
        public PasswordProfile PasswordProfile { get; set; }

        /// <summary>
        /// Gets or sets the user principal name (someuser@contoso.com). It
        /// must contain one of the verified domains for the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "userPrincipalName")]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the mail alias for the user.
        /// </summary>
        [JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Gets or sets this must be specified if you are using a federated
        /// domain for the user's userPrincipalName (UPN) property when
        /// creating a new user account. It is used to associate an on-premises
        /// Active Directory user account with their Azure AD user object.
        /// </summary>
        [JsonProperty(PropertyName = "immutableId")]
        public string ImmutableId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (PasswordProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PasswordProfile");
            }
            if (UserPrincipalName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserPrincipalName");
            }
            if (MailNickname == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MailNickname");
            }
            if (PasswordProfile != null)
            {
                PasswordProfile.Validate();
            }
        }
    }
}