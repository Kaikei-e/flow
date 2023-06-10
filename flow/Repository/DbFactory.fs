module flow.Repository.DbFactory

open Dapper.FSharp.MySQL
open System.Data
open MySql.Data.MySqlClient

Dapper.FSharp.MySQL.OptionTypes.register()

let connectionString = "Server=localhost;Database=flow;Uid=root;Pwd=;"
let db: IDbConnection = new MySqlConnection(connectionString)



