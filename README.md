# Dotnet-Microservices-Platforme

Building two .NET Microservices using the GRPC API pattern

Techinacl Asspects of microservices
And please don't demonize the monolith

**Starting with SRP : Single Responsability Principle**

Robert C.Martin : Gather together those things that change for the same reason , and separete those things that changes for different reasons

Benifits : Resilient , Scalable , Increased organizational

That's also called : Event driven architecture

after creating ur application u must build it with docker to do this u craete a Docker file and after u must execute the following command

> docker build -t ayoubkassi/platformservice .

and to run it u use :

> docker run -- 8080:80 -d ayoubkassi/platformservice

push ur image into dockerhub

> docker push ayoubkassi/platformservice

passing now to K8S , we will start by creating deployment for each service

first : create yaml file for ur deployment and after run the command :

> kubectl apply -f platforms-depl.yaml
