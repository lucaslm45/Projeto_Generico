﻿using PaymentAPI.Models.Entities;

namespace PaymentAPI.Data.Repositories.Interfaces {
    /// <summary>
    /// Interface responsible for defining database operations for the <see cref="TransactionEntity"/> entity.
    /// </summary>
    public interface ITransactionRepository {
        /// <summary>
        /// Creates a new transaction in the database.
        /// </summary>
        /// <param name="entity">The transaction entity to be created.</param>
        /// <returns>Returns the created transaction.</returns>
        Task<TransactionEntity> Create(TransactionEntity entity);

        /// <summary>
        /// Retrieves a transaction by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the transaction.</param>
        /// <returns>Returns the transaction if found, otherwise, null.</returns>
        Task<TransactionEntity> GetById(Guid id);

        /// <summary>
        /// Updates an existing transaction in the database.
        /// </summary>
        /// <param name="entity">The transaction entity to be updated.</param>
        /// <returns>Returns the updated transaction.</returns>
        Task<TransactionEntity> Update(TransactionEntity entity);
    }
}