namespace ST_BLL.Interfaces
{
    public interface IPasswordHasher
    {
        public byte[] Hash(string password);
    }
}