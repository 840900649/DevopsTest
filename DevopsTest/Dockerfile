#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#拉取带有图像处理的镜像
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
#容器时区错误问题
ENV TZ=Asia/Shanghai
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
#设置工作路径
WORKDIR /app
COPY . .
#如果使用配置文件的端口，此端口将无效
EXPOSE 80
#注意：修改 DockerTest.dll的值
ENTRYPOINT ["dotnet", "DevopsTest.dll"]