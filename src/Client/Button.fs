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

type ButtonProps =
    {
        Content: ReactElement
        OnClick: (MouseEvent -> unit)
        ClassName: string
        Label: string
        Disabled: bool
    }

module Button =
    let genericButton (props: ButtonProps) =
        let className = props.ClassName
        let label = props.Label

        button [
                OnClick (props.OnClick)
                Label label
                ClassName className
                if props.Disabled then
                    HTMLAttr.Disabled true ] [
            props.Content
        ]
