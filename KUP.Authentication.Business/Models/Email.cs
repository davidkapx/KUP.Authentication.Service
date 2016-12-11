using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace KUP.Authentication.Business.Models
{
    public class Email
    {

        public const string EMAILTYPE_PRIMARY = "PRIMARY";
        public const string EMAILTYPE_SECONDARY = "ALTMAIL2";
        public const string EMAILTYPE_KAPLAN = "KAPEMAIL";

        [System.ComponentModel.DataAnnotations.RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is invalid.")]
        public string Address
        {
            get;
            set;
        }

        public string EmailType
        {
            get;
            set;
        }

        public String EmailTypeDisplayName
        {
            get;
            set;
        }

        //This is a ficticius property to determine the subscription
        public Boolean IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Sorts email addresses by type.  Order is Primary, Secondary, Other, Kaplan.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public static int SortEmailAddressesByType(Models.Email x, Models.Email y)
        {
            string emailTypeX = x.EmailType.ToUpper();
            string emailTypeY = y.EmailType.ToUpper();

            if (string.Compare(emailTypeX, emailTypeY, true) == 0)
                return 0;

            if (emailTypeX == EMAILTYPE_PRIMARY) return -1;
            if (emailTypeX == EMAILTYPE_KAPLAN) return 1;
            if (emailTypeX == EMAILTYPE_SECONDARY)
            {
                if (emailTypeY == EMAILTYPE_PRIMARY) return 1;
                else return -1;
            }

            return 0;
        }

        public bool IsReadOnly
        {
            get
            {
                //TODO: Implement businessunit-specific behavior here...for now, we're hard-coding KHEC business rules because I have 40 minutes to fix this.
                //if (this.EmailType.CaseInsensitiveTrimmedEquals(EMAILTYPE_PRIMARY))
                    return false;

                return true;
            }
        }

    }
}
