namespace Client

open Fable.React
open Fable.React.Props
open Elmish
open Fable.Remoting.Client
open Fable.React.Standard
open Shared
open Fable.React
open Fable.React.Props
open Browser.Types
open Fable.Core.JsInterop


module CommonComponents =
    let formatNumber (num: int) =
        num?toLocaleString("sv-SE")

    let tagTextComponent (tagText: string) =
        div [ Class "tags-container" ] [
            span [ Class "tags-text" ] [str $"{tagText}"]
        ]

    let formatValue (value: int) (showCurrency: bool) =
        let stringValue =
            if showCurrency then
                $"{value |> formatNumber} kr"
            else
                $"{value |> formatNumber}"

        div [ Class "num-container" ] [
            span [ Class "numeric-stats" ] [str stringValue]
        ]

    let statsContainerComponent (stats: int * int) =
        let createStatComponent label value showCurrency =
            div [] [
                tagTextComponent label
                formatValue value showCurrency
            ]

        div [ Class "container" ] [
            createStatComponent "Orders count" (fst stats) false
            createStatComponent "Total sales" (snd stats) true
        ]