namespace Flow

module Main =
    open Microsoft.AspNetCore.Builder
    open Microsoft.AspNetCore.Http
    open Microsoft.Extensions.Hosting
    open System



    [<EntryPoint>]
    let main args =
            use db = 
            
            let builder = WebApplication.CreateBuilder(args)
            let app = builder.Build()

            app.UseRouting() |> ignore
            app.UseEndpoints(fun endpoints ->
                endpoints.MapGet(
                    "/system/health",
                    fun (context: HttpContext) ->
                        context.Response.StatusCode <- 200
                        context.Response.WriteAsync("OK")
                    ) |> ignore
                ) |> ignore
            
            app.Run()
            
            0 // return an integer exit code