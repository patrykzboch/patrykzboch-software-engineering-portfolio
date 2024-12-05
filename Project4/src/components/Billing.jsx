import { apple, brainstorm, google } from "../assets";
import styles, { layout } from "../style";
//test
const Billing = () => (
  <section id="product" className={layout.sectionReverse}>
    <div className={layout.sectionImgReverse}>
      <img src={brainstorm} alt="billing" className="w-[90%] h-[90%] relative z-[5]" />

      {/* gradient start */}
      <div className="absolute z-[3] -left-1/2 top-0 w-[50%] h-[50%] rounded-full white__gradient" />
      <div className="absolute z-[0] w-[50%] h-[50%] -left-1/2 bottom-0 rounded-full pink__gradient" />
      {/* gradient end */}
    </div>

    <div className={layout.sectionInfo}>
      <h2 className={styles.heading2}>
        Easily collaborate with <br className="sm:block hidden" /> people &
        groups
      </h2>
      <p className={`${styles.paragraph} max-w-[470px] mt-5`}>
        Experience seamless collaboration with BrainWave's cutting-edge
        brainstorming platform. Our innovative solution empowers individuals and groups to
        easily come together, fostering a dynamic environment for idea generation.
      </p>

      <div className="flex flex-row flex-wrap sm:mt-10 mt-6">
        <a href="https://www.apple.com/app-store/" target="_blank" rel="noopener noreferrer">
          <img src={apple} alt="Apple App Store" className="w-[128.86px] h-[42.05px] object-contain mr-5 cursor-pointer" />
        </a>
        <a href="https://play.google.com/" target="_blank" rel="noopener noreferrer">
          <img src={google} alt="Google Play Store" className="w-[144.17px] h-[43.08px] object-contain cursor-pointer" />
        </a>
      </div>
    </div>
  </section>
);

export default Billing;
