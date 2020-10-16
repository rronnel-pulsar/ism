(*

    version 1.

    # Assumption
        - Transition States are simillar between swimlanes.
        - Generalized Transition for any action.
*)

type Inspection = {
    id: string
    name: string
}

// TODO. unhappy path cases.
type BasicTransition =
    | Idle
    | Loading
    | Loaded
type FadingTransition =
    | Idle
    | Loading
    | Loaded
    | FadingIn
    | FadingOut
type FlyingTransition =
    | Idle
    | Loading
    | Flying
    | Loaded

type CardTransitionTypes =
    | None
    | Basic of BasicTransition
    | Fading of FadingTransition
    | Flying of FlyingTransition

type CardState =
    | Idle
    | Loading
    | Loaded

type Card = {
    cardId: string
    inspectionId: string

    cardState: CardState                    // ------\
                                            //        |----> mutual exlusive!
    transitionTypes: CardTransitionTypes    // ------/
}

type SwimlaneName =
    | Annotating
    | Review
    | Done

type Swimlane = {
    name: SwimlaneName
    items: Card list
}

type Board = Swimlane list


let card = {
    cardId= "1"
    inspectionId= "1"

    cardState= Idle
    transitionTypes= Fading FadingTransition.Loading // we can't transition while the card is idle!
}

