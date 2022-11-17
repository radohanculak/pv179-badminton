﻿using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Data;
using Sprint.DAL.EFCore.Models;
using Sprint.Infrastructure.Repository;

namespace Sprint.Infrastructure.EFCore.Repository;

public class EFTrainerReservationRepository : ITrainerReservationRepository
{
    internal SprintDbContext _dbContext;

    internal DbSet<TrainerReservation> dbSet;

    public EFTrainerReservationRepository(SprintDbContext dbContext)
    {
        _dbContext = dbContext;
        dbSet = _dbContext.Set<TrainerReservation>();
    }

    public async virtual Task<TrainerReservation?> GetByIdAsync(Guid id)
    {
        return dbSet
            .Include(t => t.Trainer)
            .Include(t => t.CourtReservation)
            .Include(t => t.TrainerReview)
            .FirstOrDefault(t => t.Id == id);
    }

    public async Task<IEnumerable<TrainerReservation>> GetAllAsync()
    {
        return await dbSet
            .Include(t => t.Trainer)
            .Include(t => t.CourtReservation)
            .Include(t => t.TrainerReview)
            .ToListAsync();
    }

    public async virtual Task<Guid> InsertAsync(TrainerReservation entity)
    {
        var entry = await dbSet.AddAsync(entity);

        return entry.Entity.Id;
    }

    public virtual void Delete(TrainerReservation entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }

    public virtual void Update(TrainerReservation entityToUpdate)
    {
        dbSet.Attach(entityToUpdate);
        _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
    }

    public virtual async Task DeleteByIdAsync(Guid id)
    {
        var entityToDelete = await dbSet.FindAsync(id);
        if (entityToDelete is not null)
        {
            Delete(entityToDelete);
        }
    }

    public virtual async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<TrainerReservation>> GetReservationsForTrainer(Guid trainerId)
    {
        return dbSet
           .Include(t => t.Trainer)
           .Include(t => t.CourtReservation)
           .Include(t => t.TrainerReview)
           .Where(r => r.TrainerId == trainerId);
    }
}
