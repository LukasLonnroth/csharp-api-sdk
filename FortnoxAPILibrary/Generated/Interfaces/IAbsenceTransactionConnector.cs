using System;
using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface IAbsenceTransactionConnector : IConnector
	{
        [SearchParameter("filter")]
		Filter.AbsenceTransaction? FilterBy { get; set; }

        string EmployeeId { get; set; }
        DateTime? Date { get; set; }

		AbsenceTransaction Update(AbsenceTransaction absenceTransaction);

		AbsenceTransaction Create(AbsenceTransaction absenceTransaction);

		AbsenceTransaction Get(string employeeId, DateTime? date, AbsenceCauseCode? code);

		void Delete(string employeeId, DateTime? date, AbsenceCauseCode? code);

		EntityCollection<AbsenceTransaction> Find();

	}
}
