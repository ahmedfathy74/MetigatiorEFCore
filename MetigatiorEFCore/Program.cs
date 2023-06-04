using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cache;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using Remotion.Linq.Clauses.ResultOperators;
using System.Data;

//var configuration = new ConfigurationBuilder()
//     .AddJsonFile("appsettings.json")
//     .Build();

//var walletToInsert = new Wallet
//{
//    Holder = "Menna",
//    Balance = 5500
//};

//SqlConnection conn = new SqlConnection(configuration.GetSection("constr").Value);

////var sql = "SELECT * FROM WALLETS";

//var sql = "INSERT INTO WALLETS (Holder, Balance) VALUES (@Holder,@Balance)";

//SqlParameter holderParameter = new SqlParameter
//{
//    ParameterName = "@Holder",
//    SqlDbType = SqlDbType.VarChar,
//    Direction = ParameterDirection.Input,
//    Value = walletToInsert.Holder
//};
//SqlParameter BalanceParameter = new SqlParameter
//{
//    ParameterName = "@Balance",
//    SqlDbType = SqlDbType.Decimal,
//    Direction = ParameterDirection.Input,
//    Value = walletToInsert.Balance
//};

//SqlCommand command = new SqlCommand(sql, conn);

//command.Parameters.Add(holderParameter);
//command.Parameters.Add(BalanceParameter);

//command.CommandType = CommandType.Text;
//conn.Open();

//if(command.ExecuteNonQuery() > 0)
//{
//    Console.WriteLine($"Wallet for {walletToInsert.Holder} added successfully");
//}


////SqlDataReader reader = command.ExecuteReader();

////Wallet wallet;

////while(reader.Read())
////{
////    wallet = new Wallet
////    {
////        Id = reader.GetInt32("Id"),
////        Holder = reader.GetString("Holder"),
////        Balance = reader.GetDecimal("Balance")
////    };
////    Console.WriteLine(wallet);

////}
//conn.Close();
//////////////////////-----Nhibernate-----------/////////
///
//using(var session = CreateSession())
//{
//    Console.WriteLine(session.IsConnected);
//}
//using(var session = CreateSession())
//{
//    using(var transaction = session.BeginTransaction())
//    {
//        //var wallets = session.Query<Wallet>();
//        //foreach(var wallet in wallets)
//        //{
//        //    Console.WriteLine(wallet);
//        //}
//        //////////////////////////////
//        //int walletToFind = 2;
//        //var wallet = session.Query<Wallet>()
//        //    .FirstOrDefault(x => x.Id == walletToFind);
//        //Console.WriteLine(wallet);
//        /////////////////////////////
//        //var wallettoAdd = new Wallet { Holder = "smith", Balance = 0 };
//        //session.Save(wallettoAdd);
//        //Console.WriteLine(wallettoAdd);
//        //transaction.Commit();
//        /////////////////////////////////
//        //var idToUpdate = 4;
//        //var wallet = session.Get<Wallet>(idToUpdate);
//        //wallet.Balance = 5000m;
//        //session.Update(wallet);
//        //transaction.Commit();
//        //Console.WriteLine(wallet);
//        //////////////////////
//        ///
//        //var idToDelete = 4;
//        //var wallet = session.Get<Wallet>(idToDelete);
//        //session.Delete(wallet);
//        //transaction.Commit();
//        ///////////////////////////
//        //var idFrom = 2;
//        //var idTo = 3;
//        //var amountToTransfer = 1000;
//        //var walletFrom = session.Get<Wallet>(idFrom);
//        //var walletTo = session.Get<Wallet>(idTo);
//        //walletFrom.Balance -= amountToTransfer;
//        //walletTo.Balance += amountToTransfer; 
//        //session.Update(walletFrom);
//        //session.Update(walletTo);
//        //transaction.Commit();
//    }
//}
//static ISession CreateSession()
//{
//    var config = new ConfigurationBuilder()
//        .AddJsonFile("appsettings.json")
//        .Build();

//    var constr = config.GetSection("constr").Value;

//    var mapper = new ModelMapper();
//    // list all of type mappings from assembly

//    mapper.AddMappings(typeof(Wallet).Assembly.ExportedTypes);

//    // Complie class mapping
//    HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
//    var hbConfig = new Configuration();
//    hbConfig.DataBaseIntegration(c =>
//    {
//        c.Driver<MicrosoftDataSqlClientDriver>();
//        c.Dialect<MsSql2012Dialect>();
//        c.ConnectionString = constr;
//        //c.LogSqlInConsole = true;
//       // c.LogFormattedSql = true;
//    });
//    hbConfig.AddMapping(domainMapping);
//    var sesssionFactory = hbConfig.BuildSessionFactory();
//    var session = sesssionFactory.OpenSession();
//    return session;
//}





