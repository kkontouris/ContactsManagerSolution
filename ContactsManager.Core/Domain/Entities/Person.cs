using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Person
	{
		[Key]
		public Guid PersonId { get; internal set; }

		public string? PersonName { get; internal set; }
		public string? Email { get; internal set; }
		public DateTime? DateOfBirth { get; internal set; }
		public string? Gender { get; internal set; }
		public Guid? CountryId { get; internal set; }
		public string? Address { get; internal set; }
		public bool ReceiveNewsLeters { get; internal set; }
		public string? TaxIdentificationNumber { get; internal set; }

		[ForeignKey("CountryId")]
		public Country? Country { get; internal set; }

		// Factory method for updating properties
		public void UpdatePerson(string? personName, string? email, DateTime? dateOfBirth, string? gender, string? address, bool receiveNewsLeters, string? taxIdentificationNumber)
		{
			PersonName = personName;
			Email = email;
			DateOfBirth = dateOfBirth;
			Gender = gender;
			Address = address;
			ReceiveNewsLeters = receiveNewsLeters;
			TaxIdentificationNumber = taxIdentificationNumber;
		}

		// Constructor με validation
		public Person(string? personName, string? email, DateTime? dateOfBirth, string? gender, Guid? countryId,
					  string? address, bool receiveNewsLeters, string? taxIdentificationNumber)
		{
			// Validation για PersonName
			if (string.IsNullOrWhiteSpace(personName) || personName.Length > 40)
			{
				throw new ArgumentException("Το όνομα δεν πρέπει να είναι κενό και δεν πρέπει να υπερβαίνει τους 40 χαρακτήρες.");
			}

			// Validation για Email
			if (string.IsNullOrWhiteSpace(email) || email.Length > 40)
			{
				throw new ArgumentException("Το email δεν πρέπει να είναι κενό και δεν πρέπει να υπερβαίνει τους 40 χαρακτήρες.");
			}

			// Validation για Gender
			if (gender != null && gender.Length > 10)
			{
				throw new ArgumentException("Το φύλο δεν πρέπει να υπερβαίνει τους 10 χαρακτήρες.");
			}

			// Validation για Address
			if (address != null && address.Length > 200)
			{
				throw new ArgumentException("Η διεύθυνση δεν πρέπει να υπερβαίνει τους 200 χαρακτήρες.");
			}

			// Validation για TaxIdentificationNumber
			if (taxIdentificationNumber != null && taxIdentificationNumber.Length != 9)
			{
				throw new ArgumentException("Ο ΑΦΜ πρέπει να έχει ακριβώς 9 χαρακτήρες.");
			}

			// Εφόσον τα validations περάσουν, αποθηκεύουμε τις τιμές
			PersonId = Guid.NewGuid();  // Αυτόματη δημιουργία νέου Guid για το PersonId
			PersonName = personName;
			Email = email;
			DateOfBirth = dateOfBirth;
			Gender = gender;
			CountryId = countryId;
			Address = address;
			ReceiveNewsLeters = receiveNewsLeters;
			TaxIdentificationNumber = taxIdentificationNumber;
		}
	}
}
