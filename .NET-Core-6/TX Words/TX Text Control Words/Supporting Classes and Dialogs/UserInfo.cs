/*-------------------------------------------------------------------------------------------------------------
** UserInfo.cs File
**
** Description:
**     Provides information about a user.
**
** copyright:		© Text Control GmbH
**-----------------------------------------------------------------------------------------------------------*/
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TXTextControl.Words {
	/*-------------------------------------------------------------------------------------------------------------
	** Class UserInfo
	** Capsulates the user's info like name and password. The password is stored as a SHA1 Hash.
	**-----------------------------------------------------------------------------------------------------------*/
	public class UserInfo {

		/*-------------------------------------------------------------------------------------------------------------
		** M E M B E R S
		**-----------------------------------------------------------------------------------------------------------*/

		private string m_strName;                   // User's name
		private byte[] m_rbPasswordHash;            // User's password as SHA1 Hash
		private bool m_bIsSignedIn = false;         // A flag that determines whether or not the user is signed in.


		/*-------------------------------------------------------------------------------------------------------------
		** C O N S T R U C T O R S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
        ** UserInfo Constructor
        ** This constructor is required for de-/serialization which will be done when saving and loading the 
        ** application's settings.
        **-----------------------------------------------------------------------------------------------------------*/
		public UserInfo() { }

		/*-------------------------------------------------------------------------------------------------------------
        ** UserInfo Constructor
        ** Creates a new UserInfo instance representing the specified user with the specified password.
        **
        ** Parameters:
        **      userName:   The name of the user.
        **      password:   The user's password.
        **-----------------------------------------------------------------------------------------------------------*/
		public UserInfo(string userName, string password) {
			m_strName = userName;
			m_rbPasswordHash = ComputeSHA1Hash(password);
			m_bIsSignedIn = true;
		}

		/*-------------------------------------------------------------------------------------------------------------
		** P R O P E R T I E S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** Name Property
		** Gets or sets the name of the user that is represented by this UserInfo instance.
		**-----------------------------------------------------------------------------------------------------------*/
		public string Name { get { return m_strName; } set { m_strName = value.Trim(); } }

		/*-------------------------------------------------------------------------------------------------------------
		** PasswordHash Property
		** Gets or sets the hashed password.
		**-----------------------------------------------------------------------------------------------------------*/
		public byte[] PasswordHash { get { return m_rbPasswordHash; } set { m_rbPasswordHash = value; } }

		/*-------------------------------------------------------------------------------------------------------------
        ** IsSignedIn Property
        ** Gets or sets a value indicating whether the user is signed in or not.
        **-----------------------------------------------------------------------------------------------------------*/
		internal bool IsSignedIn { get { return m_bIsSignedIn; } set { m_bIsSignedIn = value; } }


		/*-------------------------------------------------------------------------------------------------------------
		** O V E R R I D D E N   M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** Equals Method (overridden)
		** Equals the object. This instance and the passed object are equal if the object is a UserInfo and 
		** the names are case insensitive equal.
		**-----------------------------------------------------------------------------------------------------------*/
		public override bool Equals(object obj) {
			if (obj == null) return false;
			var that = obj as UserInfo;
			return this.Equals(that);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** GetHashCode Method (overridden)
		**-----------------------------------------------------------------------------------------------------------*/
		public override int GetHashCode() { return base.GetHashCode(); }


		/*-------------------------------------------------------------------------------------------------------------
		** M E T H O D S
		**-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** ValidatePassword Method
		** Validates whether the passed password is equal to the set password of this user info by comparing
		** the SHA1 hashs.
		**
		** Parameters:
		**      password:   The password to validate.
		**
		** Returns: True, if the specified password is correct. Otherwise false.
		**-----------------------------------------------------------------------------------------------------------*/
		public bool ValidatePassword(string password) {
			return !string.IsNullOrEmpty(password) && m_rbPasswordHash.SequenceEqual(ComputeSHA1Hash(password));
		}

		/*-------------------------------------------------------------------------------------------------------------
        ** ComputeSHA1Hash Method
        ** Computes a SHA1 hash from the specified text.
        **
        ** Parameters:
        **      text:   The text that is used to compute a SHA1 hash.
        **
        ** Returns: The computed SHA1 hash from the specified text.
        **-----------------------------------------------------------------------------------------------------------*/
		private byte[] ComputeSHA1Hash(string text) {
			if (string.IsNullOrEmpty(text)) return new byte[0];
			SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
			return sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
		}

		/*-------------------------------------------------------------------------------------------------------------
		** Equals Method
		** This instance and the passed UserInfo are equal if the names are case insensitive equal.
		**
		** Parameters:
		**      user:   The UserInfo instance to compare with.
		** 
		**  Returns: True if this instance equals to the specified UserInfo object. Otherwise false.
		**-----------------------------------------------------------------------------------------------------------*/
		public bool Equals(UserInfo user) {
			return (user != null) && this.Name.Equals(user.Name, StringComparison.OrdinalIgnoreCase);
		}


		/*-------------------------------------------------------------------------------------------------------------
        ** O P E R A T O R S
        **-----------------------------------------------------------------------------------------------------------*/

		/*-------------------------------------------------------------------------------------------------------------
		** ==  operator
		** These instances are equal if the names are case insensitive equal.
		**-----------------------------------------------------------------------------------------------------------*/
		public static bool operator ==(UserInfo a, UserInfo b) {
			return object.ReferenceEquals(a, b) || a.Equals(b);
		}

		/*-------------------------------------------------------------------------------------------------------------
		** !=  operator
		** These instances are not equal if the names are not case insensitive equal.
		**-----------------------------------------------------------------------------------------------------------*/
		public static bool operator !=(UserInfo a, UserInfo b) {
			return !(a == b);
		}
	}
}