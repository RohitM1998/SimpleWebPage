# Use the official Nginx image as the base image
FROM nginx:latest

# Set the working directory inside the container
WORKDIR /usr/share/nginx/html

# Copy HTML files from the host into the Nginx web server's root directory
COPY C:\Users\rmarathe\Desktop\Jenkins\Demo\*.html ./

# Copy CSS files from the host into the Nginx web server's root directory
COPY C:\Users\rmarathe\Desktop\Jenkins\Demo\*.css ./

# Expose port 87 to allow outside access to your web server
EXPOSE 87
