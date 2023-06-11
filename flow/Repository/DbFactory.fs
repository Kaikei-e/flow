module DbFactory

open System.Data
open MySql.Data.MySqlClient

type public Initializer() =
    static member Open() =
        let connectionString = "Server=localhost;Database=flow;Uid=root;Pwd=;"
        let db: IDbConnection = new MySqlConnection(connectionString)
        db.Open()
        db


// module Creation =
//     type Start =
//         static member Open() =
//             let connectionString = "Server=localhost;Database=flow;Uid=root;Pwd=;"
//             let db: IDbConnection = new MySqlConnection(connectionString)
//             db