using actuariallearning.Courses.DbContextManager;
using Microsoft.EntityFrameworkCore;

namespace actuariallearning.Courses.Interfaces
{
    
	public abstract class SimpleEntityRepository<V, T>: IRepository<V, T>  where T:class{

        private readonly CourseContext? courseContext;

        public void delete(T Entity)
        {
          
            throw new NotImplementedException();
        }

        public void deleteAllById(IEnumerable<V> EntityId)
        {
            throw new NotImplementedException();
        }

        public void deleteById(V EntityId)
        {
            _ = courseContext.Set<T>().Where(u => u.GetType().GetField("id").Equals(EntityId)).ExecuteDelete();
        }

        //Get as an Entity relating to the specified class by Id
        public Task<T> getById(V EntityId)
        {
            try
            {
                T? entity = (T?) courseContext.Set<T>().Where(u => u.GetType().GetField("id").Equals(EntityId));
                return Task.FromResult(entity!);
            }
            catch (NotImplementedException)
            {
                throw new NotImplementedException("Could find entitty");
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Could not find field with name id");
            }

        }


        // Gets all list of entities with id in id list
        public async Task<IEnumerable<T>> getAllById(IEnumerable<V> EntityIds)
        {
            List<Task<T>> entities = new List<Task<T>>();

            foreach(V id in EntityIds)
            {
                entities.Add(getById(id));
            }

            return await Task.WhenAll(entities);
            
        }

        public void save(T Entity)
        {

            if (Entity.Equals(null))
            {
                throw new NullReferenceException("Entity should not be null");
            }


            throw new NotImplementedException();
        }

        public void saveAll(IEnumerable<T> Entities)
        {
            throw new NotImplementedException();
        }

        public void update(T Entity)
        {
            throw new NotImplementedException();
        }

        public void updateById(V EntityId)
        {
            throw new NotImplementedException();
        }

    }
}

