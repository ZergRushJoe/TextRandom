module Types
    type Detail = {
        Name: string
        Description: string
    }

    type Terrain = 
    | GrassLand of Detail
    | Desert of Detail
    | Water of Detail
    | Forest of Detail

    type Feature =
    | River of Detail
    | Waterfall of Detail
    | Cliff of Detail

    type Hex = {
        HexLocation: int * int
        Terrain: Terrain
        Detail: Detail
        Features: Feature list
    }

    type World = {
        Detail: Detail
        HexMap: Map<int*int, Hex>
        CurrentHex: int*int
    }