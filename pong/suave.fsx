#r "suave.dll"

open System
open System.Net
open Suave.Types
open Suave.Web
open Suave.Http
open Suave.Http.Applicatives
open Suave.Log

let app : WebPart = Successful.OK "pong"

let config =
    { default_config with
       bindings = [ { scheme = HTTP ; ip = IPAddress.Parse "127.0.0.1" ; port = 3000us } ];
       buffer_size = 2048;
       max_ops = 10000
    }

web_server config app
