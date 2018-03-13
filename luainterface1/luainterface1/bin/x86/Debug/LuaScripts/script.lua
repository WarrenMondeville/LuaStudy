print("________________asdf")

--不需要引用
--require "luanet"

luanet.load_assembly("System")

Int32= luanet.import_type("System.Int32")
print(Int32)

num = Int32.Parse("3256")
print(num)



 
luanet.load_assembly("luainterface1")
Program = luanet.import_type("luainterface1.Program")

program1 = Program()

print(program1.name) 
program1:CLRMethod() 

void, strlength = program1:TestOut("wwwwwwwwwww")
print(void, strlength);


void, count=program1:TestRef("dddddddddddddd",10)

print(void ,count)
--[[

]]--

