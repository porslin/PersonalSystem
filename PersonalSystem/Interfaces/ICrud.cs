namespace PersonalSystem.Interfaces
{
    public interface ICrud<T> where T : class
    {   
        // allows adding 
        bool Add(T entity);

        // allows updating
        bool Update(T entity);

        // allows removing
        bool Delete(T entity);

        T GetById(int id);


        List<T> GetAll();
    }
}
