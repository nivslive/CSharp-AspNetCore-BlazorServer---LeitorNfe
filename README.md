# TaskManagement - README

Esta aplicação web está usando como tecnologia:
no frontend Blazor Server, e no backend ASP.NET Core.

## Instruções para subir o Database (usando Docker)

### 1. No terminal, inicie as imagens SQL Server:
sudo docker run --platform linux/amd64 -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=set_your_password_here" \
   -p 1433:1433 --name sql1 --hostname sql1 \
   -d \
   mcr.microsoft.com/mssql/server:2022-latest

### 2. Não esqueça de mudar a senha, de acordo com o que está vinculado no appsetttings
Em LeitorNfe/appsettings.json, haverá o seguinte dado:

  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=leitornfe;User Id=sa;Password=set_your_password_here;TrustServerCertificate=true"
  },

coloque em Password={} o que foi colocado no comando do terminal para subir a imagem docker em: "MSSQL_SA_PASSWORD={}"


## Instruções para o Backend

### 1. Navegue até a pasta do Core da aplicação:

cd LeitorNfe

### 2. Atualize as dependências usando o dotnet:
dotnet restore

### 3. Execute as migrações do banco de dados para criar as tabelas necessárias:
dotnet ef database update


### 4. Inicie o servidor de desenvolvimento:
dotnet watch run


## PRINTS
<img src="https://img001.prntscr.com/file/img001/H0mcglhRSOCBC6DUpu9gXA.png">