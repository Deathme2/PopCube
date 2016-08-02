# Das byte code
This is a stack baced language, with a vriable table, no gpr, with PC

# Things to think of
- [ ] Call FraMES
- [x] Stack
- [x] var tables
- [ ] oop
- [ ] var repezentaion
- [ ] logic
- [ ] branshing
- [ ] artmitick
- [ ] trheads
- [ ] opcodes


# opcodes

opcodeid, paramater

## St.Loc
ID: 1
Peramater 1: i32

## Ld.Loc
ID: 1
Peramater 1: i32

## Jmp.u
ID: 3
Peramater 1: i32

## Add
ID: 4
Pop's the item form stack[A], pops item from stack[B], adds A and B push value onto stack

## Load.str
ID : 16

*Note*: string format is u32 lentgh directly follow by byte array, ascii of length

## Load.i8
ID : 17

## Load.i16
ID : 18

## Load.i32
ID : 19

## Load.u8
ID : 20

## Load.u16
ID : 21

## Load.u32
ID : 22