//-----------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Truextend.AdmStudent.DAO
{
	using System;
	using System.Collections.Generic;

    /// <summary>
    /// The generic interface for the repositories
    /// </summary>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        ///     Generic function for insert a new record.
        /// </summary>
        /// <param name="entity">The current entity object for insert.</param>        
        /// <returns>A int corresponding to the records modified.</returns>        
        int Insert(T entity);

        /// <summary>
        ///     Generic function for delete a new record.
        /// </summary>
        /// <param name="entity">The current entity object for delete.</param>        
        /// <returns>A boolean that indicate if the transaction was success.</returns>        
        bool Delete(T entity);

        /// <summary>
        ///     Generic function for update a specific record.
        /// </summary>
        /// <param name="entity">The current entity object for update.</param>        
        /// <returns>A int corresponding to the records modified.</returns>        
        int Update(T entity);

        /// <summary>
        ///     Generic function for delete a new record based in it's id.
        /// </summary>
        /// <param name="id">The current object id.</param>        
        /// <returns>A boolean that indicate if the transaction was success.</returns>        
        bool Delete(Guid id);

        /// <summary>
        ///     Generic function for return a list of items .
        /// </summary>        
        /// <returns>A list of object type entity</returns>        
        IEnumerable<T> GetAll();

        /// <summary>
        ///     Generic function for insert a new record.
        /// </summary>
        /// <param name="entity">The current entity object for insert.</param>        
        /// <returns>A list of entity object entity based in the id.</returns>        
        IEnumerable<T> FindById(Guid id);
    }
}
