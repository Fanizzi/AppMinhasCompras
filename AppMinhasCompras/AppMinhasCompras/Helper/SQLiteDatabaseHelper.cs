using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppMinhasCompras.Model;
using SQLite;

namespace AppMinhasCompras.Helper
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Produto>().Wait();
        }
        public Task<int> Insert(Produto p)
        {
            return _connection.InsertAsync(p);
        }

        public void Update(Produto p)
        {
            string sql = "UPDATE Produto SET Descricao=?, Quantidade=?, Preco=? WHETE id= ?";

            _connection.QueryAsync<Produto>(sql, p.Descricao, p.Quantidade, p.Preco, p.Id);
        }

        public Task<Produto> getById(int id)
        {
            return new Produto();
        }

        public Task<List<Produto>> getAll()
        {
            return _connection.Table<Produto>().ToListAsync();
        }

        public void Delete(int id)
        {
            _connection.Table<Produto>().DeleteAsync(i => i.Id == id);
        }
    }
}
