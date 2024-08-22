using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryContracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;

namespace Repositories
{
	public class PersonsRepository : IPersonsRepository
	{
		private readonly ApplicationDbContext _dB;
		private readonly ILogger<PersonsRepository> _logger;
        public PersonsRepository(ApplicationDbContext dB, ILogger<PersonsRepository> logger)
        {
				_dB= dB;
			_logger= logger;
        }
        public async Task<Person> AddPerson(Person person)
		{
			_dB.Persons.Add(person);
			await _dB.SaveChangesAsync();
			return person;

		}

		public async Task<bool> DeletePersonWithPersonIdAsync(Guid personId, CancellationToken token)
		{
			try {
				_dB.Persons.RemoveRange(_dB.Persons.Where(temp => temp.PersonId == personId));
				int rowsDeleted = await _dB.SaveChangesAsync(token);

				return rowsDeleted > 0;
			}
			catch (OperationCanceledException)
			{
				// Ακύρωση λειτουργίας
				return false;
			}
			catch (Exception)
			{
				// Διαχείριση άλλων σφαλμάτων
				throw;
			}

		}



		public async Task<List<Person>> GetAllPersons()
		{
			return await _dB.Persons.Include("Country").ToListAsync();
		}

		public async Task<List<Person>> GetFilteredPersons(Expression<Func<Person, bool>> predicate)
		{
			return await _dB.Persons.Include("Country")
				.Where(predicate)
				.ToListAsync();
		}

		public async Task<Person?> GetPersonByPersonId(Guid? personId)
		{
			return await _dB.Persons.Include("Country")
				.Where(temp=>temp.PersonId==personId)
				.FirstOrDefaultAsync();
		}


		public async Task<Person> UpdatePerson(Person person)
		{
			Person? matchingPerson = await _dB.Persons.FirstOrDefaultAsync(temp => temp.PersonId == person.PersonId);

			if (matchingPerson == null)
			{
				return person;
			}

			// Use the update method to change the properties
			matchingPerson.UpdatePerson(
				personName: person.PersonName,
				email: person.Email,
				dateOfBirth: person.DateOfBirth,
				gender: person.Gender,
				address: person.Address,
				receiveNewsLeters: person.ReceiveNewsLeters,
				taxIdentificationNumber: person.TaxIdentificationNumber
			);

			int countUpdated=await _dB.SaveChangesAsync();
			return matchingPerson;



		}
	}
}
