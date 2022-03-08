<template>
  <div class="about">
    <div class="imageContainer"></div>

    <div class="wrapper">
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <div><span class="dot"></span></div>
      <h1>What is Travelers?</h1>
      <p>
        Travelers is place where adventurous people meet so that they can share
        they ideas and experiences
      </p>
      <h2>How does it work?</h2>
      <p>
        Under the blog page you can write a article for other
        <strong>Travelers</strong> to read so that they can get some inspiration
        and ideas for new journeys. Any experience can be written and saved for
        others to read. If you are not shy don't hesitate to add a image.
      </p>
      <h2>Can anyone add a blog?</h2>
      <p>
        At the moment anyone can add a post without having to register to our
        website.
      </p>
      <h2>Are you missing something?</h2>
      <p>
        If you have any idea on how to upgrade or improve our website just let
        us know via the contact form or email. We will review your mail and if
        possible add it to the site.
      </p>
      <blockquote>--Enjoy your Travelers team--</blockquote>
    </div>
  </div>
</template>
<style scoped>
.about {
  display: flex;
  height: 85vh;
  overflow: hidden;
  padding: 10px 5px;
  margin-top: 10px;
  background: #F6E4AD;
}

.imageContainer {
  background: url("../assets/images/about.jpg") no-repeat center;
  background-size: 80% 95%;
  width: 50%;
}

* {
  margin: 0;
  padding: 0;
}

.wrapper {
  width: 50%;
  height: 85vh;
  right: 0;
  position: absolute;
}

.wrapper div {
  height: 60px;
  width: 60px;
  border: 2px solid rgba(255, 255, 255, 0.7);
  border-radius: 50px;
  position: absolute;
  top: 10%;
  left: 10%;
  animation: 4s linear infinite;
}

div .dot {
  height: 10px;
  width: 10px;
  border-radius: 50px;
  background: rgba(255, 255, 255, 0.5);
  position: absolute;
  top: 20%;
  right: 20%;
}

.wrapper div:nth-child(1) {
  top: 20%;
  left: 20%;
  animation: animate 8s linear infinite;
}

.wrapper div:nth-child(2) {
  top: 60%;
  left: 80%;
  animation: animate 10s linear infinite;
}

.wrapper div:nth-child(3) {
  top: 40%;
  left: 40%;
  animation: animate 3s linear infinite;
}

.wrapper div:nth-child(4) {
  top: 66%;
  left: 30%;
  animation: animate 7s linear infinite;
}

.wrapper div:nth-child(5) {
  top: 90%;
  left: 10%;
  animation: animate 9s linear infinite;
}

.wrapper div:nth-child(6) {
  top: 30%;
  left: 60%;
  animation: animate 5s linear infinite;
}

.wrapper div:nth-child(7) {
  top: 70%;
  left: 20%;
  animation: animate 8s linear infinite;
}

.wrapper div:nth-child(8) {
  top: 75%;
  left: 60%;
  animation: animate 10s linear infinite;
}

.wrapper div:nth-child(9) {
  top: 50%;
  left: 50%;
  animation: animate 6s linear infinite;
}

.wrapper div:nth-child(10) {
  top: 45%;
  left: 20%;
  animation: animate 10s linear infinite;
}

.wrapper div:nth-child(11) {
  top: 10%;
  left: 90%;
  animation: animate 9s linear infinite;
}

.wrapper div:nth-child(12) {
  top: 20%;
  left: 70%;
  animation: animate 7s linear infinite;
}

.wrapper div:nth-child(13) {
  top: 20%;
  left: 20%;
  animation: animate 8s linear infinite;
}

.wrapper div:nth-child(14) {
  top: 60%;
  left: 5%;
  animation: animate 6s linear infinite;
}

.wrapper div:nth-child(15) {
  top: 90%;
  left: 80%;
  animation: animate 9s linear infinite;
}

@keyframes animate {
  0% {
    transform: scale(0) translateY(0) rotate(70deg);
  }
  100% {
    transform: scale(1.3) translateY(-100px) rotate(360deg);
  }
}

.wrapper h1 {
  padding-top: 16%;
}

.wrapper p {
  padding: 15px;
  width: 50%;
  text-align: justify;
  margin: auto;
}

.wrapper blockquote {
  padding-top: 20px;
  width: 50%;
  margin: auto;
  text-align: right;
}
</style>
