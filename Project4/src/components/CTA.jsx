import styles from "../style";
import { Link } from "react-router-dom";
import Button from "./Button";

const CTA = () => (
  <section className={`${styles.flexCenter} ${styles.marginY} ${styles.padding} sm:flex-row flex-col bg-black-gradient-2 rounded-[20px] box-shadow`}>
    <div className="flex-1 flex flex-col">
      <h2 className={styles.heading2}>Try our BrainWave platform!</h2>
      <p className={`${styles.paragraph} max-w-[470px] mt-5`}>
        
        Fuel business growth with collaborative success. Innovate and elevate with
        BrainWave's dynamic platform, where effective collaboration meets innovative
        solutions.

      </p>
    </div>

    <div className={`${styles.flexCenter} sm:ml-10 ml-0 sm:mt-0 mt-10`}>
      <a href="https://brainwave-3d32a.firebaseapp.com/" target="_blank" rel="noopener noreferrer">
        <Button />
      </a>
    </div>
  </section>
);

export default CTA;