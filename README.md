# OSI Layer
OSI Model Stands for **Open System Interconnection Model**. OSI Model defines and is used to understand, **How Data is transferred from one computer to another in a Computer Network.** In the most basic form, Two computer connected to each other with LAN Cable and connectors by sharing datas with help of NICs(Network Interface Cards) forms a network. But IF one computer is based on Microsoft Windows and the other one have Mac OS installed then how these two computers are going to communicate with eachother ? In order to accomplish a successful communication between computers,networks or different architectures  several layers of OSI Model was introduced by ISO(International Organization for standardization) in 1984 Containing:

- [Application Layer](#application-layer)


Each Layers are Package of Protocols.

## Application Layer

Application layer is a type of layer which consists of application layer protocol which allows network applications(i.e, those applications which uses internet) to work correctly in network.For File transfer FTP(File Transfer Protocol) is used,for web surfing HTTP/HTTPS (Hyper Text Transfer Protocol/Hyper Text Transfer Protocol Secure) is used,for Emails SMTP (Simple Mail Transfer Protocol) is used, for virtual terminals TELNET(Telecommunication Network) is used.

## [Presentation Layer](#presentation-layer)

Presentation layer receives data from application layer those are in form of characters and numbers. Presentation layer converts those characters and numbers to machine understandable binary format.(Example: ASCII----101110101).This function of presentation layer  is called translation. Before data is transmitted, Presentation layer reduces the number of bits that are used to represent the original data. This bit reduction process is called Data Compression. Data compression reduces the amount of space used to store the original file as the size of file reduced it can be received in destination in very less time. To maintain the integrity of data before transmission,Data is encrypted(At Senders side: Data is encrypted and in Receivers side: Data is Decrypted). SSL(Secure Sockets Layer)is used in presentation layer for data encryption and decryption.Thus, Presentation  layer performs three functions:
1)Translation
2)Data Compression
3)Encryption/Decryption

## [Session Layer](#session-layer)

Session layer helps in setting up and managing connections enabling sending and receiving of data followed by terminations of connections or sessions. Session layer has its own helpers called APIs(Application Programming Interfaces). NETBIOS (Network Basic Output System) is an example of APIs which allows applications on different computer to communicate with eachother. Just before a session/connection is established with a server, Server performs a function called Authentication(It is the process of verifying : who you are ?). After Authenticating a user, Authorization(It is the process used by server to determine If you have permission to accessify or not) is checked. If not then you will get message "You are not authorized to access this page". Session layer also helps in Session Management.

## [Transport Layer](#transport-layer)

The layer below session layer is transport layer.Transport layer controls the reliablity of communication through flow control,error control and segmentation. Transport Layer protocols are TCP(Transport Control Protocol) and UDP(User Datagram Protocol). Transport layer does to types of services (Connection Oriented Transmission and Connectionless Transmission) .
Connection Oriented Transmission is done via TCP while Connection less Transmission is done via UDP.
UDP is faster than TCP.
UDP does not provides Feedback whereas TCP provides Feedback.
Lost data cannot be restored in UDP whereas Lost data can be restored in TCP.
 
## [Network Layer](#network-layer)

Transport Layer sends data segments to the network layer. Network Layer works for the transmission of the recieved data segments from one computer to another located in different locations. Data Units in Network Layer is called Data-Packets.
The Function of Network Layer are:
1. Logical Addressing
2. Routing
3. Path Determination

## [Data Link Layer](#data-link-layer)

Data link layer receives data packets from network layer. Data packets contains IP addresses of sender and receiver. There are two types of addressing: 
1. Logical Addressing
2. Physical Addressing

Logical Addressing is done at network layer where senders and receivers IP addresses are assigned to each segments to form a data packets. Physical Addressing layer is done at data link layer where MAC addresses of sender and receiver are assigned to each data packets to form a frame. (MAC Address is 12 digit Alpha-Character Number) Data unit in data link layer is called Frame.

## [Physical Layer](#physical-layer)

Till now, Data from Application Layer has  been segmented by Transport Layer placed into Packets by Network Layer and Framed by Data Link Layer which is a sequence of binary 0's and 1's.Physical layer converts this binary BIT'S into SIGNALS  and transmit over local media. It can be an electrical signal incase of Copper cable or LAN cable, Light signal incase of Optical Fiber and Radio Signal in case of AIR. So signal generated by physical layer depends in the type of media used to connect two devices. At the receiver, Physical Layer receives signal and converts to BIT'S and pass it to Data Link Layer as a Frame. Frame is further decapsulated as data moves through higher layers. Finally,data is moved to Application Layer. Application Layer Protocol makes the sender's message visible in the application in the receiver's computer screen.

In this way, OSI model is helping to transfer data between different hosts. So, these Seven Layers pf OSI model are lying behind the smooth functioning of Internet.
