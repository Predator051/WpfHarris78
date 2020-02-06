win64\bin\protoc -I=./proto --csharp_out=./src proto\*.proto --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe
pause